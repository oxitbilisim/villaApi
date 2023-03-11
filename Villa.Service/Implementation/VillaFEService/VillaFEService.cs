using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using AutoMapper;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MimeKit.Text;
using Org.BouncyCastle.Utilities;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Dtos.VillaFE;
using Villa.Domain.Entities;
using Villa.Domain.Enum;
using Villa.Domain.Interfaces;
using Villa.Domain.Utilities;
using Villa.Persistence;
using Villa.Service.Base;
using Villa.Service.Contract;

namespace Villa.Service.Implementation;

public class VillaFEService
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    private readonly VillaService _villaService;
    private readonly VillaImageDetayService _villaImageDetayService;
    private readonly VillaLokasyonService _villaLokasyonService;
    private readonly VillaIcerikService _villaIcerikService;
    private readonly VillaKategoriService _villaKategoriService;
    private readonly VillaOzellikService _villaOzellikService;
    private readonly VillaGorunumService _villaGorunumService;
    private readonly VillaPeriyodikFiyatService _villaPeriyodikFiyatService;
    private readonly VillaPeriyodikFiyatAyarlariService _villaPeriyodikFiyatAyarlariService;
    private readonly VillaSeoService _villaSeoService;

    private readonly BlogService _blogService;
    private readonly BlogIcerikService _blogIcerikService;
    private readonly BlogSeoService _blogSeoService;

    public VillaFEService(appDbContext appDbContext,
        VillaService villaService,
        VillaImageDetayService villaImageDetayService,
        VillaLokasyonService villaLokasyonService,
        VillaIcerikService villaIcerikService,
        VillaKategoriService villaKategoriService,
        VillaOzellikService villaOzellikService,
        VillaGorunumService villaGorunumService,
        VillaPeriyodikFiyatService villaPeriyodikFiyatService,
        VillaSeoService villaSeoService,
        VillaPeriyodikFiyatAyarlariService villaPeriyodikFiyatAyarlariService,
        IMapper mapper)
    {
        _mapper = mapper;
        _villaService = villaService;
        _villaImageDetayService = villaImageDetayService;
        _villaLokasyonService = villaLokasyonService;
        _villaIcerikService = villaIcerikService;
        _villaKategoriService = villaKategoriService;
        _villaOzellikService = villaOzellikService;
        _villaGorunumService = villaGorunumService;
        _villaPeriyodikFiyatService = villaPeriyodikFiyatService;
        _villaPeriyodikFiyatAyarlariService = villaPeriyodikFiyatAyarlariService;
        _appDbContext = appDbContext;
        _villaSeoService = villaSeoService;
    }

    public List<BolgeDtoFQ> GetBolge(int rules)
    {
        var bolge = _appDbContext.Bolge.Where(x => !x.IsDeleted && x.Active).Select(x => new BolgeDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            Image = rules == 1 ? x.Image : null,
            Toplam = _appDbContext.VillaLokasyon.Where(y =>
                    y.Active == true && y.Villa.Active == true && y.BolgeId == x.Id && !y.IsDeleted &&
                    !y.Villa.IsDeleted)
                .Count()
        }).ToList();
        return bolge;
    }

    public PaginationData GetBolgeVillas(int bolgeId,
        int pageNumber,
        int pageRowCount)
    {
        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var endDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1));

        var villaQuery = _appDbContext.VillaLokasyon
            .Where(x => x.BolgeId == bolgeId && !x.Villa.IsDeleted && x.Villa.Active);
        var searchResult =
            villaQuery.Skip((pageNumber - 1) * pageRowCount).Take(pageRowCount).Select(x => new VillaDtoFQ
            {
                Id = x.Villa.Id,
                Ad = x.Villa.Ad,
                Url = x.Villa.Url,
                ImageId = x.Villa.VillaImage != null
                    ? x.Villa.VillaImageDetay.Where(i => i.KapakResmi.Value).FirstOrDefault().Id
                    : null,
                Bolge = x.Villa.VillaLokasyon.Where(y => !y.IsDeleted).FirstOrDefault().Bolge.Ad,
                Il = x.Ilce.Il.Ad,
                Ilce = x.Ilce.Ad,
                Fiyat = x.Villa.PeriyodikFiyat
                    .Where(pf =>
                        DateTime.Today >= pf.Baslangic.Date && DateTime.Today <= pf.Bitis.Date && !pf.IsDeleted)
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Villa.Kapasite,
                Mevki = x.Mevki,
                BanyoSayisi = x.Villa.BanyoSayisi,
                FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.Villa.PeriyodikFiyat.Where(f_ => !f_.IsDeleted)
                    .FirstOrDefault().FiyatTuru),
                ParaBirimi = x.Villa.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                OdaSayisi = x.Villa.OdaSayisi,
                YatakOdaSayisi = x.Villa.YatakOdaSayisi
            }).ToList();

        foreach (var item in searchResult)
        {
            item.ToplamFiyat = CostCalculate(item.Id.Value, startDate, endDate).TotalPrice;
        }

        return new PaginationData()
        {
            data = searchResult,
            CurrentPage = pageNumber,
            TotalPage = (int)Math.Ceiling((decimal)villaQuery.Count() / pageRowCount),
            Count = villaQuery.Count()
        };
    }

    public List<KategoriDtoFQ> GetKategori(int rules)
    {
        var kategori = _appDbContext.Kategori.Where(x => !x.IsDeleted).Select(x => new KategoriDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            IconName = x.IconName,
            Image = rules == 1 ? x.Image : null,
            Toplam = _appDbContext.VillaKategori.Where(y => y.KategoriId == x.Id && !y.IsDeleted && !y.Villa.IsDeleted)
                .Count()
        }).ToList();

        return kategori;
    }

    public PaginationData GetKategoriVillas(int kategoriId,
        int pageNumber,
        int pageRowCount)
    {
        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var endDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1));

        var villaQuery = _appDbContext.VillaKategori
            .Where(i => !i.Villa.IsDeleted)
            .Where(x => x.KategoriId == kategoriId && !x.IsDeleted && x.Villa.Active);

        var searchResult =
            villaQuery.Skip((pageNumber - 1) * pageRowCount).Take(pageRowCount).Select(x => new VillaDtoFQ
            {
                Id = x.Villa.Id,
                Ad = x.Villa.Ad,
                Url = x.Villa.Url,
                ImageId = x.Villa.VillaImage != null
                    ? x.Villa.VillaImageDetay.Where(i => i.KapakResmi.Value).FirstOrDefault().Id
                    : null,
                Bolge = x.Villa.VillaLokasyon.Where(vl => !vl.IsDeleted).FirstOrDefault().Bolge.Ad,
                Il = x.Villa.VillaLokasyon.Where(vl => !vl.IsDeleted).FirstOrDefault().Ilce.Il.Ad,
                Ilce = x.Villa.VillaLokasyon.Where(vl => !vl.IsDeleted).FirstOrDefault().Ilce.Ad,
                Fiyat = x.Villa.PeriyodikFiyat
                    .Where(pf =>
                        DateTime.Today >= pf.Baslangic.Date && DateTime.Today <= pf.Bitis.Date && !pf.IsDeleted)
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Villa.Kapasite,
                Mevki = x.Villa.VillaLokasyon.Where(vl => !vl.IsDeleted).FirstOrDefault().Mevki,
                BanyoSayisi = x.Villa.BanyoSayisi,
                FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.Villa.PeriyodikFiyat.FirstOrDefault().FiyatTuru),
                ParaBirimi = x.Villa.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                OdaSayisi = x.Villa.OdaSayisi,
                YatakOdaSayisi = x.Villa.YatakOdaSayisi
            }).ToList();

        foreach (var item in searchResult)
        {
            item.ToplamFiyat = CostCalculate(item.Id.Value, startDate, endDate).TotalPrice;
        }

        return new PaginationData()
        {
            data = searchResult,
            CurrentPage = pageNumber,
            TotalPage = (int)Math.Ceiling((decimal)villaQuery.Count() / pageRowCount),
            Count = villaQuery.Count()
        };
    }

    public Sayfa GetPageByURL(string url)
    {
        return _appDbContext.Sayfa.Include(s => s.SayfaIcerik).FirstOrDefault(s => s.Url == url);
    }

    public List<Sayfa> GetAllPages()
    {
        return _appDbContext.Sayfa.Where(p => !p.IsDeleted).ToList();
    }

    public VillaFullDtoFQ GetVillaByUrl(string url)
    {
        VillaFullDtoFQ villa = new();
        villa.Villa = _appDbContext.Villa.Where(x => !x.IsDeleted && x.Url == url).Select(x => new VillaDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            Kapasite = x.Kapasite,
            BanyoSayisi = x.BanyoSayisi,
            FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.Where(x => !x.IsDeleted).FirstOrDefault()
                .FiyatTuru),
            //ParaBirimi = x.PeriyodikFiyat.Where(x => !x.IsDeleted).FirstOrDefault().ParaBirimi.Ad,
            OdaSayisi = x.OdaSayisi,
            YatakOdaSayisi = x.YatakOdaSayisi
        }).FirstOrDefault();
        villa.Seo = _villaSeoService.GetPI<VillaSeoDto>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted).Select(s =>
            new VillaSeoDto()
            {
                Id = s.Id,
                Baslik = s.Baslik,
                Aciklama = s.Aciklama,
                AnahtarKelime = s.AnahtarKelime,
                VillaId = s.VillaId,
                HtmlMetaEtiket = s.HtmlMetaEtiket
            }).FirstOrDefault();
        villa.Images = _villaImageDetayService
            .GetPI<VillaImageDetayDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted).Select(i =>
                new VillaImageDetayDtoQ
                {
                    Id = i.Id,
                    KapakResmi = i.KapakResmi,
                    Sirano = i.Sirano
                }).AsEnumerable().OrderBy(i => i.Sirano).ToList();
        villa.Lokasyon = _villaLokasyonService
            .GetPI<VillaLokasyonDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted)
            .FirstOrDefault();
        villa.Icerik = _villaIcerikService.GetPI<VillaIcerikDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted)
            .FirstOrDefault();
        villa.Kategori = _villaKategoriService
            .GetPI<VillaKategoriDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted).ToList();
        villa.Ozellik = _villaOzellikService.GetPI<VillaOzellikDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted)
            .ToList();
        villa.Gorunum = _villaGorunumService.GetPI<VillaGorunumDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted)
            .FirstOrDefault();

        villa.PeriyodikFiyat = generatePrices(villa.Villa.Id.Value);

        villa.PeriyodikFiyatAyarlari = _villaPeriyodikFiyatAyarlariService
            .GetPI<VillaPeriyodikFiyatAyarlariDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted).ToList();

        var periyodikFiyat = _appDbContext.PeriyodikFiyat.Include(pf => pf.ParaBirimi)
            .Where(pf => pf.VillaId == villa.Villa.Id && DateTime.Today >= pf.Baslangic.Date &&
                         DateTime.Today <= pf.Bitis.Date && !pf.IsDeleted)
            .FirstOrDefault();
        if (periyodikFiyat != null)
        {
            villa.Villa.discountRate = periyodikFiyat.Indirim;
            villa.Villa.Fiyat = periyodikFiyat.Fiyat;
            villa.Villa.IndirimliFiyat = periyodikFiyat.Indirim != null
                ? periyodikFiyat.Fiyat * (100 - periyodikFiyat.Indirim) / 100
                : periyodikFiyat.Fiyat;
            villa.Villa.ParaBirimi = periyodikFiyat.ParaBirimi.Ad;
        }

        return villa;
    }

    private List<VillaPeriyodikFiyatDtoQ> generatePrices(int villaId)
    {
        var baseList = _villaPeriyodikFiyatService
            .GetPI<VillaPeriyodikFiyatDtoQ>(x =>
                x.VillaId == villaId && x.Bitis.CompareTo(DateTimeOffset.Now) >= 0 && !x.IsDeleted)
            .OrderBy(x => x.Baslangic)
            .ToList();
        if (baseList.Count == 0)
        {
            return new List<VillaPeriyodikFiyatDtoQ>();
        }

        List<VillaPeriyodikFiyatDtoQ> result = new List<VillaPeriyodikFiyatDtoQ>(baseList);

        List<ParaBirimi> currencyList = _appDbContext.ParaBirimi.Where(p => !p.IsDeleted).ToList();
        List<ExchangeRates> exchangeRates = _appDbContext.ExchangeRates.Where(p => !p.IsDeleted).ToList();

        foreach (VillaPeriyodikFiyatDtoQ item in baseList)
        {
            int existCurrencyId = item.ParaBirimiId;
            ParaBirimi existCurrency = currencyList.Find(p => p.Id == existCurrencyId);
            List<ParaBirimi> nonExistCurrency = currencyList.Where(p => p.Id != existCurrencyId).ToList();

            foreach (ParaBirimi currency in nonExistCurrency)
            {
                var isExit = result.Where(c =>
                    c.Baslangic == item.Baslangic && c.Bitis == item.Bitis && c.ParaBirimiAd == currency.Ad).Any();
                if (isExit)
                {
                    break;
                }

                VillaPeriyodikFiyatDtoQ newObj = item.clone();
                newObj.ParaBirimiId = currency.Id;
                newObj.ParaBirimiAd = currency.Ad;

                if (existCurrency.Ad == "TRY")
                {
                    var rate = exchangeRates.Find(e => !e.IsDeleted && e.to == currency.Ad);
                    if (rate == null)
                    {
                        break;
                    }

                    newObj.Fiyat = newObj.Fiyat / (decimal)rate.rate;
                }
                else if (currency.Ad == "TRY")
                {
                    var rate = exchangeRates.Find(e => !e.IsDeleted && e.to == existCurrency.Ad);
                    if (rate == null)
                    {
                        break;
                    }

                    newObj.Fiyat = newObj.Fiyat * (decimal)rate.rate;
                }
                else
                {
                    var rateTRY = exchangeRates.Find(e => !e.IsDeleted && e.to == existCurrency.Ad);
                    if (rateTRY == null)
                    {
                        break;
                    }

                    var rate = exchangeRates.Find(e => !e.IsDeleted && e.to == currency.Ad);
                    if (rateTRY == null)
                    {
                        break;
                    }

                    newObj.Fiyat = newObj.Fiyat * (decimal)rateTRY.rate / (decimal)rate.rate;
                }

                result.Add(newObj);
            }
        }

        return result.OrderBy(s => s.Baslangic).ToList();
    }

    public List<VillaDtoFQ> GetPopularVillas(int limit)
    {
        var VillaQuery = _appDbContext.VillaGosterim
            .Where(i => i.Villa.IsDeleted == false && i.Gosterim == Gosterim.Onecikan)
            .Include(i => i.Villa).AsQueryable();
        if (limit > 0)
        {
            VillaQuery = VillaQuery.Take(limit);
        }

        var result = VillaQuery.Select(x => new VillaDtoFQ
        {
            Id = x.Villa.Id,
            Ad = x.Villa.Ad,
            Url = x.Villa.Url,
            ImageId = x.Villa.VillaImage != null ? x.Villa.VillaImageDetay.FirstOrDefault().Id : null,
            Bolge = x.Villa.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Bolge.Ad,
            Il = x.Villa.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Ilce.Il.Ad,
            Ilce = x.Villa.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Ilce.Ad,
            Fiyat = x.Villa.PeriyodikFiyat
                .Where(pf => DateTime.Today >= pf.Baslangic.Date && DateTime.Today <= pf.Bitis.Date)
                .FirstOrDefault().Fiyat,
            Kapasite = x.Villa.Kapasite,
            Mevki = x.Villa.VillaLokasyon.FirstOrDefault().Mevki,
            BanyoSayisi = x.Villa.BanyoSayisi,
            FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.Villa.PeriyodikFiyat.FirstOrDefault().FiyatTuru),
            ParaBirimi = x.Villa.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
            OdaSayisi = x.Villa.OdaSayisi,
            YatakOdaSayisi = x.Villa.YatakOdaSayisi
        }).ToList();

        return result;
    }

    public byte[] GetRegionImage(int id)
    {
        var image = _appDbContext.Bolge.Find(id);
        return image.Image;
    }

    public byte[] GetVillaImage(int id)
    {
        var image = _appDbContext.VillaImageDetay.Find(id);
        return image.Image;
    }

    public List<OzellikDtoFQ> GetAllProperty()
    {
        var properties = _appDbContext.Ozellik.Where(i => !i.IsDeleted).Select(i => new OzellikDtoFQ()
        {
            Id = i.Id,
            Ad = i.Ad
        }).OrderBy(i => i.Ad).ToList();
        return properties;
    }

    public List<Mulk> GetAllEstates()
    {
        var properties = _appDbContext.Mulk.Where(i => !i.IsDeleted)
            .OrderBy(i => i.Ad).ToList();
        return properties;
    }

    public PaginationData SearchVillas(List<int> filterRegion,
        List<int> filterCategory,
        List<int> filterType,
        List<int> filterProperty,
        string filterName,
        decimal filterStartPrice,
        decimal filterEndPrice,
        DateOnly filterStartDate,
        DateOnly filterEndDate,
        int filterGuestCount,
        int pageNumber,
        int pageRowCount
    )
    {
        var villaQuery = _appDbContext.Villa.Where(v => !v.IsDeleted && v.Active).AsQueryable();

        if (filterName != null)
        {
            villaQuery = villaQuery
                .Where(i => i.Ad.ToLower().Contains(filterName.ToLower()));
        }

        if (filterGuestCount > 0)
        {
            villaQuery = villaQuery
                .Where(i => i.Kapasite >= filterGuestCount);
        }

        if (filterType.Count > 0)
        {
            villaQuery = villaQuery
                .Where(i => filterType.Any(t => t == i.MulkId));
        }

        if (filterRegion.Count > 0)
        {
            villaQuery = villaQuery
                .Where(i => i.VillaLokasyon.Where(vl => !vl.IsDeleted)
                    .FirstOrDefault(l =>
                        filterRegion.Contains(l.BolgeId)
                    ) != null);
        }

        if (filterCategory.Count > 0)
        {
            villaQuery = villaQuery
                .Where(i => i.VillaKategori.Where(vk =>
                                    filterCategory.Any(f => f == vk.KategoriId) && vk.VillaId == i.Id && !vk.IsDeleted)
                                .Count() ==
                            filterCategory.Count());
        }

        if (filterProperty.Count > 0)
        {
            villaQuery = villaQuery
                .Where(i => i.VillaOzellik.Where(vl => !vl.IsDeleted && filterProperty.Any(f => f == vl.OzellikId))
                        .Count() == filterProperty.Count()
                );
        }

        if (filterStartPrice > -1 || filterEndPrice > -1)
        {
            if (filterStartDate == DateOnly.MinValue)
            {
                filterStartDate = DateOnly.FromDateTime(DateTime.Now);
            }

            if (filterEndDate == DateOnly.MaxValue)
            {
                filterEndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(1));
            }

            villaQuery = villaQuery.Where(i => i.PeriyodikFiyat.AsEnumerable().Where(pf => !pf.IsDeleted &&
                    (((DateOnly.FromDateTime(pf.Baslangic.Date)
                           .CompareTo(filterStartDate) == 0 ||
                       DateOnly.FromDateTime(pf.Baslangic.Date)
                           .CompareTo(filterStartDate) == 1) &&
                      DateOnly.FromDateTime(pf.Baslangic.Date)
                          .CompareTo(filterEndDate) == -1) ||
                     ((DateOnly.FromDateTime(pf.Bitis.Date)
                           .CompareTo(filterStartDate) == 1 ||
                       DateOnly.FromDateTime(pf.Bitis.Date).CompareTo(filterStartDate) == 0) &&
                      (DateOnly.FromDateTime(pf.Bitis.Date)
                           .CompareTo(filterEndDate) == -1 ||
                       DateOnly.FromDateTime(pf.Bitis.Date)
                           .CompareTo(filterEndDate) == 0)) ||
                     (DateOnly.FromDateTime(pf.Baslangic.Date)
                          .CompareTo(filterStartDate) == -1 &&
                      DateOnly.FromDateTime(pf.Bitis.Date)
                          .CompareTo(filterEndDate) == 1)))
                .Count() == i.PeriyodikFiyat.AsEnumerable().Where(pf => !pf.IsDeleted &&
                                                                        ((pf.Fiyat * pf.ParaBirimi.TryOran) >=
                                                                         filterStartPrice ||
                                                                         filterStartPrice == -1) &&
                                                                        ((pf.Fiyat * pf.ParaBirimi.TryOran) <=
                                                                         filterEndPrice ||
                                                                         filterEndPrice == -1) &&
                                                                        (((DateOnly.FromDateTime(pf.Baslangic.Date)
                                                                               .CompareTo(filterStartDate) == 0 ||
                                                                           DateOnly.FromDateTime(pf.Baslangic.Date)
                                                                               .CompareTo(filterStartDate) == 1) &&
                                                                          DateOnly.FromDateTime(pf.Baslangic.Date)
                                                                              .CompareTo(filterEndDate) == -1) ||
                                                                         ((DateOnly.FromDateTime(pf.Bitis.Date)
                                                                               .CompareTo(filterStartDate) == 1 ||
                                                                           DateOnly.FromDateTime(pf.Bitis.Date)
                                                                               .CompareTo(filterStartDate) == 0) &&
                                                                          (DateOnly.FromDateTime(pf.Bitis.Date)
                                                                               .CompareTo(filterEndDate) ==
                                                                           -1 ||
                                                                           DateOnly.FromDateTime(pf.Bitis.Date)
                                                                               .CompareTo(filterEndDate) ==
                                                                           0)) ||
                                                                         (DateOnly.FromDateTime(pf.Baslangic.Date)
                                                                              .CompareTo(filterStartDate) == -1 &&
                                                                          DateOnly.FromDateTime(pf.Bitis.Date)
                                                                              .CompareTo(filterEndDate) ==
                                                                          1))).Count());
        }

        if (filterStartDate != DateOnly.MinValue && filterEndDate != DateOnly.MaxValue)
        {
            villaQuery = villaQuery
                .Where(i => i.Rezervasyon.Where(r =>
                        !r.IsDeleted &&
                        (((DateOnly.FromDateTime(r.Baslangic.Date).CompareTo(filterStartDate) == 0 ||
                           DateOnly.FromDateTime(r.Baslangic.Date).CompareTo(filterStartDate) == 1) &&
                          DateOnly.FromDateTime(r.Baslangic.Date).CompareTo(filterEndDate) == -1) ||
                         (DateOnly.FromDateTime(r.Bitis.Date).CompareTo(filterStartDate) == 1 &&
                          (DateOnly.FromDateTime(r.Bitis.Date).CompareTo(filterEndDate) == -1 ||
                           DateOnly.FromDateTime(r.Bitis.Date).CompareTo(filterEndDate) == 0)) ||
                         (DateOnly.FromDateTime(r.Baslangic.Date).CompareTo(filterStartDate) == -1 &&
                          DateOnly.FromDateTime(r.Bitis.Date).CompareTo(filterEndDate) == 1)))
                    .OrderBy(r => r.Baslangic)
                    .Count() == 0);
        }

        if (filterStartDate == DateOnly.MinValue)
        {
            filterStartDate = DateOnly.FromDateTime(DateTime.Now);
        }

        if (filterEndDate == DateOnly.MaxValue)
        {
            filterEndDate = DateOnly.FromDateTime(DateTime.Now).AddDays(1);
        }

        var searchResult = villaQuery.OrderBy(i => i.Kapasite).Skip((pageNumber - 1) * pageRowCount).Take(pageRowCount)
            .Select(x =>
                new VillaDtoFQ
                {
                    Id = x.Id,
                    Ad = x.Ad,
                    Url = x.Url,
                    ImageId = x.VillaImage != null
                        ? x.VillaImageDetay.Where(i => i.KapakResmi.Value).FirstOrDefault(x => !x.IsDeleted).Id
                        : null,
                    Bolge = x.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Bolge.Ad,
                    Il = x.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Ilce.Il.Ad,
                    Ilce = x.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Ilce.Ad,

                    Kapasite = x.Kapasite,
                    Mevki = x.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Mevki,
                    BanyoSayisi = x.BanyoSayisi,
                    FiyatTuru = x.PeriyodikFiyat.FirstOrDefault(x => !x.IsDeleted)
                        .FiyatTuru != null
                        ? EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.FirstOrDefault(x => !x.IsDeleted)
                            .FiyatTuru)
                        : "",
                    //ParaBirimi = x.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                    OdaSayisi = x.OdaSayisi,
                    YatakOdaSayisi = x.YatakOdaSayisi
                }).ToList();

        foreach (var item in searchResult)
        {
            var periyodikFiyat = _appDbContext.PeriyodikFiyat
                .Where(pf => pf.VillaId == item.Id && !pf.IsDeleted &&
                             (((DateOnly.FromDateTime(pf.Baslangic.Date)
                                    .CompareTo(filterStartDate) == 0 ||
                                DateOnly.FromDateTime(pf.Baslangic.Date)
                                    .CompareTo(filterStartDate) == 1) &&
                               DateOnly.FromDateTime(pf.Baslangic.Date)
                                   .CompareTo(filterEndDate) == -1) ||
                              ((DateOnly.FromDateTime(pf.Bitis.Date)
                                    .CompareTo(filterStartDate) == 1 ||
                                DateOnly.FromDateTime(pf.Bitis.Date).CompareTo(filterStartDate) == 0) &&
                               (DateOnly.FromDateTime(pf.Bitis.Date)
                                    .CompareTo(filterEndDate) == -1 ||
                                DateOnly.FromDateTime(pf.Bitis.Date)
                                    .CompareTo(filterEndDate) == 0)) ||
                              (DateOnly.FromDateTime(pf.Baslangic.Date)
                                   .CompareTo(filterStartDate) == -1 &&
                               DateOnly.FromDateTime(pf.Bitis.Date)
                                   .CompareTo(filterEndDate) == 1)))
                .FirstOrDefault();
            if (periyodikFiyat != null)
            {
                item.IndirimliFiyat = periyodikFiyat.Indirim != null
                    ? periyodikFiyat.Fiyat * (100 - periyodikFiyat.Indirim) / 100
                    : periyodikFiyat.Fiyat;
                item.Fiyat = periyodikFiyat.Fiyat;
                item.discountRate = periyodikFiyat.Indirim;
            }

            var calcPrice = CostCalculate(item.Id.Value, filterStartDate, filterEndDate);
            item.ToplamFiyat = calcPrice.TotalPrice;
            item.IndirimliToplamFiyat = calcPrice.DiscountTotalPrice;
            item.ParaBirimi = calcPrice.Currency;
        }


        return new PaginationData()
        {
            data = searchResult,
            CurrentPage = pageNumber,
            TotalPage = (int)Math.Ceiling((decimal)villaQuery.Count() / pageRowCount),
            Count = villaQuery.Count()
        };
    }

    public List<CollectionResponseDto> GetVillasByIds(List<VillaIdsFQ> rb)
    {
        List<CollectionResponseDto> responseList = new List<CollectionResponseDto>();

        foreach (VillaIdsFQ item in rb)
        {
            DateTime startDate = DateTime.Parse(item.StartDate);
            DateTime endDate = DateTime.Parse(item.EndDate);
            var villa = _appDbContext.Villa
                .Where(x => !x.IsDeleted && x.Id == item.VillaId)
                .Select(x => new VillaDtoFQ
                {
                    Id = x.Id,
                    Ad = x.Ad,
                    Url = x.Url,
                    ImageId = x.VillaImage != null
                        ? x.VillaImageDetay.Where(i => i.KapakResmi.Value).FirstOrDefault(x => !x.IsDeleted).Id
                        : null,
                    Kapasite = x.Kapasite,
                    BanyoSayisi = x.BanyoSayisi,
                    FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.Where(f_ => !f_.IsDeleted)
                        .FirstOrDefault().FiyatTuru),
                    ParaBirimi = x.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                    OdaSayisi = x.OdaSayisi,
                    YatakOdaSayisi = x.YatakOdaSayisi
                }).FirstOrDefault();

            var periyodikFiyat = _appDbContext.PeriyodikFiyat
                .Where(pf => pf.VillaId == villa.Id && startDate >= pf.Baslangic.Date && startDate < pf.Bitis.Date
                             && endDate > pf.Baslangic.Date &&
                             endDate <= pf.Bitis.Date)
                .FirstOrDefault();

            if (periyodikFiyat != null)
            {
                villa.discountRate = periyodikFiyat.Indirim;
                villa.Fiyat = periyodikFiyat.Fiyat;
                villa.IndirimliFiyat = periyodikFiyat.Indirim != null
                    ? periyodikFiyat.Fiyat * (100 - periyodikFiyat.Indirim) / 100
                    : periyodikFiyat.Fiyat;
            }

            var calcPrice =
                CostCalculate(villa.Id.Value, DateOnly.FromDateTime(startDate), DateOnly.FromDateTime(endDate));
            if (calcPrice != null)
            {
                villa.ToplamFiyat = calcPrice.TotalPrice;
                villa.IndirimliToplamFiyat = calcPrice.DiscountTotalPrice;
            }

            responseList.Add(new CollectionResponseDto()
            {
                villa = villa,
                StartDate = DateOnly.FromDateTime(startDate).ToString("yyyy-MM-dd"),
                EndDate = DateOnly.FromDateTime(endDate).ToString("yyyy-MM-dd")
            });
        }

        return responseList;
    }

    public List<CollectionResponseDto> GetCollectionVillas(Guid key)
    {
        Collections collection = _appDbContext.Collections.FirstOrDefault(c => c.key == key);
        if (collection == null)
        {
            return new List<CollectionResponseDto>();
        }

        var villaList = _appDbContext.CollectionVillas.Where(v => v.CollectionsId == collection.Id)
            .ToList();
        List<CollectionResponseDto> responseList = new List<CollectionResponseDto>();

        foreach (var item in villaList)
        {
            DateTime startDate = item.StartDate.ToDateTime(TimeOnly.MinValue);
            DateTime endDate = item.EndDate.ToDateTime(TimeOnly.MinValue);
            var villa = _appDbContext.Villa
                .Where(x => !x.IsDeleted && x.Id == item.VillaId)
                .Select(x => new VillaDtoFQ
                {
                    Id = x.Id,
                    Ad = x.Ad,
                    Url = x.Url,
                    ImageId = x.VillaImage != null
                        ? x.VillaImageDetay.Where(i => i.KapakResmi.Value).FirstOrDefault(x => !x.IsDeleted).Id
                        : null,
                    Kapasite = x.Kapasite,
                    BanyoSayisi = x.BanyoSayisi,
                    FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.Where(f_ => !f_.IsDeleted)
                        .FirstOrDefault().FiyatTuru),
                    ParaBirimi = x.PeriyodikFiyat.FirstOrDefault(pf => !pf.IsDeleted).ParaBirimi.Ad,
                    OdaSayisi = x.OdaSayisi,
                    YatakOdaSayisi = x.YatakOdaSayisi
                }).FirstOrDefault();
            var periyodikFiyat = _appDbContext.PeriyodikFiyat
                .Where(pf => !pf.IsDeleted && startDate >= pf.Baslangic.Date && startDate < pf.Bitis.Date)
                .FirstOrDefault();
            if (periyodikFiyat != null)
            {
                villa.discountRate = periyodikFiyat.Indirim;
                villa.Fiyat = periyodikFiyat.Fiyat;
                villa.IndirimliFiyat = periyodikFiyat.Indirim != null
                    ? periyodikFiyat.Fiyat * (100 - periyodikFiyat.Indirim) / 100
                    : periyodikFiyat.Fiyat;
            }

            var calcPrice = CostCalculate(villa.Id.Value, DateOnly.FromDateTime(startDate),
                DateOnly.FromDateTime(endDate));
            if (calcPrice != null)
            {
                villa.ToplamFiyat = calcPrice.TotalPrice;
                villa.IndirimliToplamFiyat = calcPrice.DiscountTotalPrice;
            }

            responseList.Add(new CollectionResponseDto()
            {
                villa = villa,
                StartDate = DateOnly.FromDateTime(startDate).ToString("yyyy-MM-dd"),
                EndDate = DateOnly.FromDateTime(endDate).ToString("yyyy-MM-dd")
            });
        }

        return responseList;
    }

    public async Task<Response<Guid>> CreateCollection(List<VillaIdsFQ> rb)
    {
        var key = Guid.NewGuid();
        Collections collection = new Collections();
        collection.key = key;
        await _appDbContext.Collections.AddAsync(collection);
        await _appDbContext.SaveChangesAsync();
        var response = _appDbContext.Collections.FirstOrDefault(i => i.key == key);
        rb.ForEach(i =>
        {
            CollectionVillas cv = new CollectionVillas();
            cv.CollectionsId = response.Id;
            cv.VillaId = i.VillaId;
            cv.StartDate = DateOnly.Parse(i.StartDate);
            cv.EndDate = DateOnly.Parse(i.EndDate);

            _appDbContext.CollectionVillas.Add(cv);
        });
        await _appDbContext.SaveChangesAsync();
        return new Response<Guid>(key, message: $"Collection Registered.");
    }

    public Blog GetBlogByURL(string url)
    {
        return _appDbContext.Blog
            .Where(b => !b.IsDeleted)
            .Include(b => b.BlogIcerik)
            .Include(b => b.BlogSeo)
            .First(b => b.Url == url);
    }

    public List<Blog> GetAllBlogs()
    {
        return _appDbContext.Blog
            .Where(b => !b.IsDeleted)
            .OrderBy(b => b.CreateDate).ToList();
    }

    public byte[] GetBlogImage(int id)
    {
        var image = _appDbContext.Blog.Find(id);
        return image.Image;
    }

    public List<RezervasyonDto> GetVillaReservations(int id, int year)
    {
        List<RezervasyonDto> reservationList = _appDbContext.Rezervasyon
            .Where(r => !r.IsDeleted && r.RezervasyonDurum != RezervasyonDurum.IncelemeBekliyor && r.VillaId == id &&
                        r.Bitis >= DateTimeOffset.Now.AddMonths(-3)).Select(r => new RezervasyonDto
            {
                Id = r.Id,
                VillaId = r.VillaId,
                start = DateOnly.FromDateTime(r.Baslangic.Date).ToString("yyyy-MM-dd"),
                end = DateOnly.FromDateTime(r.Bitis.Date).ToString("yyyy-MM-dd"),
                RezervasyonDurum = r.RezervasyonDurum
            }).ToList();
        return reservationList;
    }

    public ReservationCalculation CostCalculate(int id, DateOnly startDate, DateOnly endDate)
    {
        List<PeriyodikFiyat> priceList = _appDbContext.PeriyodikFiyat.Include(p => p.ParaBirimi).AsEnumerable().Where(
            pf => pf.VillaId == id && !pf.IsDeleted &&
                  (((DateOnly.FromDateTime(pf.Baslangic.Date)
                         .CompareTo(startDate) == 0 ||
                     DateOnly.FromDateTime(pf.Baslangic.Date)
                         .CompareTo(startDate) == 1) &&
                    DateOnly.FromDateTime(pf.Baslangic.Date)
                        .CompareTo(endDate) == -1) ||
                   ((DateOnly.FromDateTime(pf.Bitis.Date)
                        .CompareTo(startDate) == 1 || DateOnly.FromDateTime(pf.Bitis.Date).CompareTo(startDate) == 0) &&
                    (DateOnly.FromDateTime(pf.Bitis.Date)
                         .CompareTo(endDate) == -1 ||
                     DateOnly.FromDateTime(pf.Bitis.Date)
                         .CompareTo(endDate) == 0)) ||
                   (DateOnly.FromDateTime(pf.Baslangic.Date)
                        .CompareTo(startDate) == -1 &&
                    DateOnly.FromDateTime(pf.Bitis.Date)
                        .CompareTo(endDate) == 1))).OrderBy(i => i.Id).ToList();

        decimal totalPrice = 0;
        decimal discountTotalPrice = 0;
        for (DateOnly sd = startDate; sd.CompareTo(endDate) == -1; sd = sd.AddDays(1))
        {
            PeriyodikFiyat price = priceList.Where(p =>
                (DateOnly.FromDateTime(p.Baslangic.DateTime).CompareTo(sd) == 0 ||
                 DateOnly.FromDateTime(p.Baslangic.DateTime).CompareTo(sd) == -1) &&
                (DateOnly.FromDateTime(p.Bitis.DateTime).CompareTo(sd) == 0 ||
                 DateOnly.FromDateTime(p.Bitis.DateTime).CompareTo(sd) == 1)).FirstOrDefault();

            if (price == null)
            {
                //throw new Exception("Fiyat bilgisi bulunamadı!");
                return new ReservationCalculation();
            }

            var calculatedPrice = price.Indirim != null ? price.Fiyat * (100 - price.Indirim) / 100 : price.Fiyat;
            totalPrice = totalPrice + price.Fiyat;
            discountTotalPrice = discountTotalPrice + calculatedPrice;
        }

        PeriyodikFiyatAyarlari fa =
            _appDbContext.PeriyodikFiyatAyarlari.FirstOrDefault(f => !f.IsDeleted && f.VillaId == id);
        if (fa == null)
        {
            //throw new Exception("Fiyat bilgisi bulunamadı!");
            return new ReservationCalculation();
        }

        VillaGorunum vg = _appDbContext.VillaGorunum.FirstOrDefault(f => f.VillaId == id);

        ReservationCalculation calc = new ReservationCalculation();
        calc.Currency = priceList[0].ParaBirimi.Ad;
        calc.DateNight = startDate.ToString("dd.MM.yyyy") + " - " + endDate.ToString("dd.MM.yyyy") + " (" +
                         (endDate.DayNumber - startDate.DayNumber).ToString() + " Gece)";
        calc.TotalPrice = totalPrice;
        calc.Deposit = fa.Depozito.Value;
        calc.CleaningFee = fa.TemizlikUcreti.Value;
        calc.DownPayment = totalPrice * fa.Kapora.Value / 100;
        calc.IncluededInPrice = vg?.OneCikanOzellik;
        calc.DiscountTotalPrice = discountTotalPrice;

        return calc;
    }

    public void UpdateExchangeRates()
    {
        string dateStr = null;
        string bulletinNo = null;
        string from = "TRY";
        string to = null;
        double rate = Double.MinValue;

        List<ExchangeRates> erList = new List<ExchangeRates>();

        List<string> currencyList = _appDbContext.ParaBirimi.Where(p => !p.IsDeleted).Select(p => p.Ad).ToList();

        string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
        XmlTextReader reader = new XmlTextReader(url);
        while (reader.Read())
        {
            if (reader.NodeType == XmlNodeType.Element && reader.Name == "Tarih_Date")
            {
                dateStr = reader.GetAttribute("Date");
                bulletinNo = reader.GetAttribute("Bulten_No");
            }

            if (reader.NodeType == XmlNodeType.Element && reader.Name == "Currency")
            {
                var code = reader.GetAttribute("Kod");
                if (currencyList.Contains(code))
                {
                    to = code;
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "BanknoteSelling")
                        {
                            rate = Double.Parse(reader.ReadInnerXml().Replace('.',','));
                            break;
                        }
                    }

                    erList.Add(new ExchangeRates()
                    {
                        from = from,
                        to = to,
                        rate = rate,
                        BulletinNo = bulletinNo,
                        CreateDate = DateTimeOffset.Now,
                        IsDeleted = false
                    });
                }
            }
        }

        if (erList.Count > 0)
        {
            var oldList = _appDbContext.ExchangeRates.ToList();
            _appDbContext.ExchangeRates.RemoveRange(oldList);
            _appDbContext.ExchangeRates.AddRange(erList);

            var pbList = _appDbContext.ParaBirimi.ToList();
            foreach (var item in pbList)
            {
                var rate_ = (decimal)(erList.FirstOrDefault(e => e.to == item.Ad) ?? new ExchangeRates()
                {
                    rate = 1
                }).rate;
                item.TryOran = rate_;
                _appDbContext.ParaBirimi.Update(item);
            }

            _appDbContext.SaveChanges();
        }
    }

    public List<EkstraHizmet> GetAllExtraServices()
    {
        return _appDbContext.EkstraHizmet
            .Where(b => !b.IsDeleted)
            .OrderBy(b => b.Ad).ToList();
    }

    public Rezervasyon saveReservation(ReservationSaveDto reservationSaveDto)
    {
        var startDate_ = DateTimeOffset.Parse(reservationSaveDto.StartDate);
        var endDate_ = DateTimeOffset.Parse(reservationSaveDto.EndDate);

        var validation = _appDbContext.Villa.Where(i => i.Id == reservationSaveDto.VillaId && i.Rezervasyon.Where(r =>
                !r.IsDeleted && r.RezervasyonDurum != RezervasyonDurum.Iptal &&
                r.RezervasyonDurum != RezervasyonDurum.IncelemeBekliyor &&
                (((DateOnly.FromDateTime(r.Baslangic.Date).CompareTo(DateOnly.FromDateTime(startDate_.DateTime)) == 0 ||
                   DateOnly.FromDateTime(r.Baslangic.Date).CompareTo(DateOnly.FromDateTime(startDate_.DateTime)) ==
                   1) &&
                  DateOnly.FromDateTime(r.Baslangic.Date).CompareTo(DateOnly.FromDateTime(endDate_.DateTime)) == -1) ||
                 (DateOnly.FromDateTime(r.Bitis.Date).CompareTo(DateOnly.FromDateTime(startDate_.DateTime)) == 1 &&
                  (DateOnly.FromDateTime(r.Bitis.Date).CompareTo(DateOnly.FromDateTime(endDate_.DateTime)) == -1 ||
                   DateOnly.FromDateTime(r.Bitis.Date).CompareTo(DateOnly.FromDateTime(endDate_.DateTime)) == 0)) ||
                 (DateOnly.FromDateTime(r.Baslangic.Date).CompareTo(DateOnly.FromDateTime(startDate_.DateTime)) == -1 &&
                  DateOnly.FromDateTime(r.Bitis.Date).CompareTo(DateOnly.FromDateTime(endDate_.DateTime)) == 1)))
            .Count() == 0).ToList();
        if (validation == null || validation.Count() == 0)
        {
            throw new Exception("Seçilen tarih aralığında başka bir rezervasyon mevcut!");
        }

        var reservation = new Rezervasyon()
        {
            VillaId = reservationSaveDto.VillaId,
            Baslangic = startDate_,
            Bitis = endDate_,
            MusteriAdSoyad = reservationSaveDto.name,
            MSYetiskin = reservationSaveDto.GuestCount,
            TelefonNo = reservationSaveDto.Phone,
            Email = reservationSaveDto.Email,
            Not = reservationSaveDto.Note,
            RezervasyonDurum = RezervasyonDurum.IncelemeBekliyor,
            CreateDate = DateTimeOffset.Now
        };

        var reservation_ = _appDbContext.Rezervasyon.Add(reservation);

        foreach (int serviceId in reservationSaveDto.ExtraServices)
        {
            _appDbContext.RezervasyonEkstraHizmet.Add(new RezervasyonEkstraHizmet()
            {
                Rezervasyon = reservation_.Entity,
                EkstraHizmetId = serviceId
            });
        }

        _appDbContext.SaveChanges();
        SendReservationMail(reservation);
        return reservation_.Entity;
    }

    public void TestMail()
    {
        var rez = _appDbContext.Rezervasyon.Find(167);
        SendReservationMail(rez);
    }

    private void SendReservationMail(Rezervasyon reservation)
    {
        var villa = _appDbContext.Villa.Find(reservation.VillaId);

        string to = reservation.Email;
        List<Parameters> parameters = _appDbContext.Parameters.Where(p => !p.IsDeleted).ToList();
        string username = parameters.First(p => p.Code == "MAIL_USERNAME")?.Value;
        string subject = parameters.First(p => p.Code == "MAIL_SUBJECT_RESERVATION_RECEIVED")?.Value;
        string mailBody = parameters.First(p => p.Code == "MAIL_BODY_RESERVATION_RECEIVED")?.Value;
        string siteLink = parameters.First(p => p.Code == "SITE_LINK")?.Value;
        ReservationCalculation prices = CostCalculate(villa.Id, DateOnly.FromDateTime(reservation.Baslangic.DateTime),
            DateOnly.FromDateTime(reservation.Bitis.DateTime));
        var lokasyon = _villaLokasyonService
            .GetPI<VillaLokasyonDtoQ>(x => x.VillaId == villa.Id && !x.IsDeleted).FirstOrDefault();
        string villaBolge = lokasyon.IlceIlAd + "," + lokasyon.BolgeAd + ", " + lokasyon.Mevki;


        mailBody = mailBody.Replace("{{VILLALARIM_LINK}}", siteLink);
        mailBody = mailBody.Replace("{{NAME}}", reservation.MusteriAdSoyad);
        mailBody = mailBody.Replace("{{CUSTOMER_PHONE}}", reservation.TelefonNo);
        mailBody = mailBody.Replace("{{CUSTOMER_EMAIL}}", reservation.Email);
        mailBody = mailBody.Replace("{{RESERVATION_CODE}}", reservation.CreateDate?.ToString("yyyyMMddHHmmss"));
        mailBody = mailBody.Replace("{{VILLA_NAME}}", villa.Ad);
        mailBody = mailBody.Replace("{{VILLA_BOLGE}}", villaBolge);
        mailBody = mailBody.Replace("{{VILLA_LINK}}", siteLink + "/villa/" + villa.Url);
        mailBody = mailBody.Replace("{{ENTRY_DATE}}", reservation.Baslangic.ToString("dd.MM.yyyy"));
        mailBody = mailBody.Replace("{{EXIT_DATE}}", reservation.Bitis.ToString("dd.MM.yyyy"));
        mailBody = mailBody.Replace("{{ACCOMMADATION_NIGHT_COUNT}}",
            (reservation.Bitis.DateTime - reservation.Baslangic.DateTime).Days + " Gece");
        mailBody = mailBody.Replace("{{GUEST_COUNT}}", reservation.MSYetiskin.ToString());
        mailBody = mailBody.Replace("{{TOTAL_PAYMENT}}", prices.TotalPrice.ToString() + prices.Currency);
        mailBody = mailBody.Replace("{{ADVANE_PAYMENT}}", prices.DownPayment.ToString() + prices.Currency);
        mailBody = mailBody.Replace("{{ENTRY_PAYMENT}}",
            (prices.TotalPrice - prices.DownPayment).ToString() + prices.Currency);

        SendMail(to, subject, mailBody);

        string infoMail = parameters.First(p => p.Code == "MAIL_INFO")?.Value;
        SendMail(infoMail, subject, mailBody);
    }

    private void SendMail(string to, string subject, string mailBody)
    {
        List<Parameters> parameters = _appDbContext.Parameters.Where(p => !p.IsDeleted).ToList();
        string host = parameters.First(p => p.Code == "MAIL_HOST")?.Value;
        string port = parameters.First(p => p.Code == "MAIL_PORT")?.Value;
        string username = parameters.First(p => p.Code == "MAIL_USERNAME")?.Value;
        string password = parameters.First(p => p.Code == "MAIL_PASSWORD")?.Value;
        string security = parameters.First(p => p.Code == "MAIL_SECURITY")?.Value;

        SecureSocketOptions secureSocketOptions = SecureSocketOptions.None;
        if (security == "SSL")
        {
            secureSocketOptions = SecureSocketOptions.SslOnConnect;
        }
        else if (security == "TLS")
        {
            secureSocketOptions = SecureSocketOptions.StartTls;
        }

        var sender = MailboxAddress.Parse(username);

        var email = new MimeMessage();
        email.From.Add(new MailboxAddress("Villalarım", username));
        email.To.Add(MailboxAddress.Parse(to));
        email.Subject = subject;
        email.Body = new TextPart(TextFormat.Html) { Text = mailBody };

        using var smtp = new SmtpClient();
        smtp.Connect(host, Int32.Parse(port), secureSocketOptions);
        smtp.Authenticate(username, password);
        smtp.Send(email);
        smtp.Disconnect(true);
    }

    public ReservationInfoDto GetReservationInfo(int reservationNo)
    {
        var reservation = _appDbContext.Rezervasyon.Find(reservationNo);
        var villa = _appDbContext.Villa.Include(v => v.VillaImageDetay)
            .FirstOrDefault(v => v.Id == reservation.VillaId);
        ReservationCalculation prices = CostCalculate(villa.Id, DateOnly.FromDateTime(reservation.Baslangic.DateTime),
            DateOnly.FromDateTime(reservation.Bitis.DateTime));
        var lokasyon = _villaLokasyonService
            .GetPI<VillaLokasyonDtoQ>(x => x.VillaId == villa.Id && !x.IsDeleted).FirstOrDefault();
        string villaBolge = lokasyon.IlceIlAd + "," + lokasyon.BolgeAd + ", " + lokasyon.Mevki;

        ReservationInfoDto info = new ReservationInfoDto();
        info.VillaName = villa.Ad;
        info.VillaRegionName = villaBolge;
        info.VillaId = villa.Id;
        info.VillaUrl = villa.Url;
        info.VillaImageId = villa.VillaImage != null
            ? villa.VillaImageDetay.Where(i => i.KapakResmi.Value).FirstOrDefault().Id
            : null;
        info.GuestName = reservation.MusteriAdSoyad;
        info.GuestCount = reservation.MSYetiskin;
        info.Phone = reservation.TelefonNo;
        info.Email = reservation.Email;
        info.EntryDate = reservation.Baslangic.DateTime;
        info.ExitDate = reservation.Bitis.DateTime;
        info.NightCount = (reservation.Bitis.DateTime - reservation.Baslangic.DateTime).Days;
        info.Currency = prices.Currency;
        info.TotalPrice = prices.TotalPrice;
        info.DownPayment = prices.DownPayment;
        info.Deposit = prices.Deposit;
        info.IncluededInPrice = prices.IncluededInPrice;
        info.CleaningFee = prices.CleaningFee;

        return info;
    }

    public List<Parameters> GetFilteredParameters()
    {
        List<string> excludeList = new List<string>();

        return _appDbContext
            .Parameters
            .Where(p => !excludeList.Contains(p.Code)).ToList();
    }
}