using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Entities;
using Villa.Domain.Enum;
using Villa.Domain.Interfaces;
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
    }

    public List<BolgeDtoFQ> GetBolge(int rules)
    {
        var bolge = _appDbContext.Bolge.Where(x => !x.IsDeleted).Select(x => new BolgeDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            Image = rules == 1 ? x.Image : null,
            Toplam = _appDbContext.VillaLokasyon.Where(y => y.BolgeId == x.Id && !y.IsDeleted && !y.Villa.IsDeleted)
                .Count()
        }).ToList();
        return bolge;
    }

    public List<VillaDtoFQ> GetBolgeVillas(int bolgeId)
    {
        var villaBolge = _appDbContext.VillaLokasyon
            .Where(x => x.BolgeId == bolgeId && !x.Villa.IsDeleted)
            .Select(x => new VillaDtoFQ
            {
                Id = x.Villa.Id,
                Ad = x.Villa.Ad,
                Url = x.Villa.Url,
                ImageId = x.Villa.VillaImage != null ? x.Villa.VillaImageDetay.FirstOrDefault().Id : null,
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

        return villaBolge;
    }

    public List<KategoriDtoFQ> GetKategori(int rules)
    {
        var kategori = _appDbContext.Kategori.Where(x => !x.IsDeleted).Select(x => new KategoriDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            Image = rules == 1 ? x.Image : null,
            Toplam = _appDbContext.VillaKategori.Where(y => y.KategoriId == x.Id && !y.IsDeleted && !y.Villa.IsDeleted)
                .Count()
        }).ToList();

        return kategori;
    }

    public List<VillaDtoFQ> GetKategoriVillas(int kategoriId)
    {
        var villaKategori = _appDbContext.VillaKategori
            .Where(i => !i.Villa.IsDeleted)
            .Where(x => x.KategoriId == kategoriId && !x.IsDeleted)
            .Select(x => new VillaDtoFQ
            {
                Id = x.Id,
                Ad = x.Villa.Ad,
                Url = x.Villa.Url,
                ImageId = x.Villa.VillaImage != null ? x.Villa.VillaImageDetay.FirstOrDefault().Id : null,
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

        return villaKategori;
    }

    public VillaFullDtoFQ GetVillaByUrl(string url)
    {
        VillaFullDtoFQ villa = new();
        villa.Villa = _appDbContext.Villa.Where(x => !x.IsDeleted && x.Url == url).Select(x => new VillaDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            Fiyat = x.PeriyodikFiyat
                .Where(pf => DateTime.Today >= pf.Baslangic.Date && DateTime.Today <= pf.Bitis.Date && !pf.IsDeleted)
                .FirstOrDefault().Fiyat,
            Kapasite = x.Kapasite,
            BanyoSayisi = x.BanyoSayisi,
            FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.Where(x => !x.IsDeleted).FirstOrDefault().FiyatTuru),
            ParaBirimi = x.PeriyodikFiyat.Where(x => !x.IsDeleted).FirstOrDefault().ParaBirimi.Ad,
            OdaSayisi = x.OdaSayisi,
            YatakOdaSayisi = x.YatakOdaSayisi
        }).FirstOrDefault();
        villa.Images = _villaImageDetayService
            .GetPI<VillaImageDetayDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted).Select(i =>
                new VillaImageDetayDtoQ
                {
                    Id = i.Id
                }).ToList();
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
        villa.PeriyodikFiyat = _villaPeriyodikFiyatService
            .GetPI<VillaPeriyodikFiyatDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted).OrderBy(x => x.Baslangic)
            .ToList();
        villa.PeriyodikFiyatAyarlari = _villaPeriyodikFiyatAyarlariService
            .GetPI<VillaPeriyodikFiyatAyarlariDtoQ>(x => x.VillaId == villa.Villa.Id && !x.IsDeleted).ToList();

        return villa;
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

    public List<VillaDtoFQ> SearchVillas(List<int> filterRegion,
        List<int> filterCategory,
        List<int> filterType,
        List<int> filterProperty,
        string filterName,
        decimal filterStartPrice,
        decimal filterEndPrice,
        DateOnly filterStartDate,
        DateOnly filterEndDate,
        int filterGuestCount
    )
    {
        var villaQuery = _appDbContext.Villa.Where(v => !v.IsDeleted).AsQueryable();

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
                          .CompareTo(filterStartDate) == 1|| DateOnly.FromDateTime(pf.Bitis.Date).CompareTo(filterStartDate) == 0 ) &&
                      (DateOnly.FromDateTime(pf.Bitis.Date)
                           .CompareTo(filterEndDate) == -1 ||
                       DateOnly.FromDateTime(pf.Bitis.Date)
                           .CompareTo(filterEndDate) == 0)) ||
                     (DateOnly.FromDateTime(pf.Baslangic.Date)
                          .CompareTo(filterStartDate) == -1 &&
                      DateOnly.FromDateTime(pf.Bitis.Date)
                          .CompareTo(filterEndDate) == 1)))
                .Count() == i.PeriyodikFiyat.AsEnumerable().Where(pf => !pf.IsDeleted &&
                                                                        (pf.Fiyat >= filterStartPrice ||
                                                                         filterStartPrice == -1) &&
                                                                        (pf.Fiyat <= filterEndPrice ||
                                                                         filterEndPrice == -1) &&
                                                                        (((DateOnly.FromDateTime(pf.Baslangic.Date)
                                                                               .CompareTo(filterStartDate) == 0 ||
                                                                           DateOnly.FromDateTime(pf.Baslangic.Date)
                                                                               .CompareTo(filterStartDate) == 1) &&
                                                                          DateOnly.FromDateTime(pf.Baslangic.Date)
                                                                              .CompareTo(filterEndDate) == -1) ||
                                                                         ((DateOnly.FromDateTime(pf.Bitis.Date)
                                                                              .CompareTo(filterStartDate) == 1|| DateOnly.FromDateTime(pf.Bitis.Date).CompareTo(filterStartDate) == 0 ) &&
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

        var searchResult = villaQuery.Select(x => new VillaDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            ImageId = x.VillaImage != null ? x.VillaImageDetay.FirstOrDefault(x => !x.IsDeleted).Id : null,
            Bolge = x.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Bolge.Ad,
            Il = x.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Ilce.Il.Ad,
            Ilce = x.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Ilce.Ad,
            Fiyat = x.PeriyodikFiyat
                .Where(pf => DateTime.Today >= pf.Baslangic.Date && DateTime.Today <= pf.Bitis.Date)
                .FirstOrDefault().Fiyat,
            Kapasite = x.Kapasite,
            Mevki = x.VillaLokasyon.FirstOrDefault(x => !x.IsDeleted).Mevki,
            BanyoSayisi = x.BanyoSayisi,
            FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.FirstOrDefault(x => !x.IsDeleted)
                .FiyatTuru),
            ParaBirimi = x.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
            OdaSayisi = x.OdaSayisi,
            YatakOdaSayisi = x.YatakOdaSayisi
        }).ToList();

        return searchResult;
    }

    public List<VillaDtoFQ> GetVillasByIds(VillaIdsFQ rb)
    {
        var villas = _appDbContext.Villa
            .Where(x => !x.IsDeleted && rb.Ids.Contains(x.Id))
            .Select(x => new VillaDtoFQ
            {
                Id = x.Id,
                Ad = x.Ad,
                Url = x.Url,
                ImageId = x.VillaImage != null ? x.VillaImageDetay.FirstOrDefault().Id : null,

                Fiyat = x.PeriyodikFiyat
                    .Where(pf => DateTime.Today >= pf.Baslangic.Date && DateTime.Today <= pf.Bitis.Date)
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Kapasite,
                BanyoSayisi = x.BanyoSayisi,
                FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.Where(f_ => !f_.IsDeleted)
                    .FirstOrDefault().FiyatTuru),
                ParaBirimi = x.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                OdaSayisi = x.OdaSayisi,
                YatakOdaSayisi = x.YatakOdaSayisi
            }).ToList();

        return villas;
    }

    public List<VillaDtoFQ> GetCollectionVillas(Guid key)
    {
        Collections collection = _appDbContext.Collections.FirstOrDefault(c => c.key == key);
        if (collection == null)
        {
            return new List<VillaDtoFQ>();
        }

        var villaIds = _appDbContext.CollectionVillas.Where(v => v.CollectionId == collection.Id).Select(v => v.VillaId)
            .ToList();
        var villas = _appDbContext.Villa
            .Where(x => !x.IsDeleted && villaIds.Contains(x.Id))
            .Select(x => new VillaDtoFQ
            {
                Id = x.Id,
                Ad = x.Ad,
                Url = x.Url,
                ImageId = x.VillaImage != null ? x.VillaImageDetay.FirstOrDefault().Id : null,

                Fiyat = x.PeriyodikFiyat
                    .Where(pf => DateTime.Today >= pf.Baslangic.Date && DateTime.Today <= pf.Bitis.Date)
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Kapasite,
                BanyoSayisi = x.BanyoSayisi,
                FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.Where(f_ => !f_.IsDeleted)
                    .FirstOrDefault().FiyatTuru),
                ParaBirimi = x.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                OdaSayisi = x.OdaSayisi,
                YatakOdaSayisi = x.YatakOdaSayisi
            }).ToList();

        return villas;
    }

    public async Task<Response<Guid>> CreateCollection(CollectionVillaFQ requestBody)
    {
        var key = Guid.NewGuid();
        Collections collection = new Collections();
        collection.key = key;
        await _appDbContext.Collections.AddAsync(collection);
        await _appDbContext.SaveChangesAsync();
        var response = _appDbContext.Collections.FirstOrDefault(i => i.key == key);
        requestBody.Ids.ForEach(i =>
        {
            CollectionVillas cv = new CollectionVillas();
            cv.CollectionId = response.Id;
            cv.VillaId = i;

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
            .Where(r => !r.IsDeleted && r.VillaId == id && r.Baslangic.Year == year).Select(r => new RezervasyonDto
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
        for (DateOnly sd = startDate; sd.CompareTo(endDate) == -1; sd = sd.AddDays(1))
        {
            PeriyodikFiyat price = priceList.Where(p =>
                (DateOnly.FromDateTime(p.Baslangic.DateTime).CompareTo(sd) == 0 ||
                 DateOnly.FromDateTime(p.Baslangic.DateTime).CompareTo(sd) == -1) &&
                (DateOnly.FromDateTime(p.Bitis.DateTime).CompareTo(sd) == 0 ||
                 DateOnly.FromDateTime(p.Bitis.DateTime).CompareTo(sd) == 1)).FirstOrDefault();

            if (price == null)
            {
                throw new Exception("Fiyat bilgisi bulunamad??!");
            }

            totalPrice = totalPrice + price.Fiyat;
        }

        PeriyodikFiyatAyarlari fa = _appDbContext.PeriyodikFiyatAyarlari.FirstOrDefault(f => f.VillaId == id);
        if (fa == null)
        {
            throw new Exception("Fiyat bilgisi bulunamad??!");
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

        return calc;
    }
}