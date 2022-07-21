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
            Toplam = _appDbContext.VillaLokasyon.Where(y => y.BolgeId == x.Id && !x.IsDeleted).Count()
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
                Il = x.Ilce.Il.Ad,
                Ilce = x.Ilce.Ad,
                Fiyat = x.Villa.PeriyodikFiyat
                    .Where(pf => DateTime.Today >= pf.Baslangic.Date  &&  DateTime.Today <= pf.Bitis.Date )
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Villa.Kapasite,
                Mevki = x.Mevki,
                BanyoSayisi = x.Villa.BanyoSayisi,
                FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.Villa.PeriyodikFiyat.Where(f_ => !f_.IsDeleted).FirstOrDefault().FiyatTuru),
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
            Toplam = _appDbContext.VillaKategori.Where(y => y.KategoriId == x.Id && !y.IsDeleted).Count()
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
                Il = x.Villa.VillaLokasyon.FirstOrDefault().Ilce.Il.Ad,
                Ilce = x.Villa.VillaLokasyon.FirstOrDefault().Ilce.Ad,
                Fiyat = x.Villa.PeriyodikFiyat
                    .Where(pf => DateTime.Today >= pf.Baslangic.Date  &&  DateTime.Today <= pf.Bitis.Date )
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Villa.Kapasite,
                Mevki = x.Villa.VillaLokasyon.FirstOrDefault().Mevki,
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
        villa.Villa = _villaService.GetAllPI<VillaDtoQ>(x => x.IsDeleted == false && x.Url == url).FirstOrDefault();
        villa.Images = _villaImageDetayService.GetPI<VillaImageDetayDtoQ>(x => x.VillaId == villa.Villa.Id).ToList();
        villa.Lokasyon = _villaLokasyonService.GetPI<VillaLokasyonDtoQ>(x => x.VillaId == villa.Villa.Id)
            .FirstOrDefault();
        villa.Icerik = _villaIcerikService.GetPI<VillaIcerikDtoQ>(x => x.VillaId == villa.Villa.Id).FirstOrDefault();
        villa.Kategori = _villaKategoriService.GetPI<VillaKategoriDtoQ>(x => x.VillaId == villa.Villa.Id).ToList();
        villa.Ozellik = _villaOzellikService.GetPI<VillaOzellikDtoQ>(x => x.VillaId == villa.Villa.Id).ToList();
        villa.Gorunum = _villaGorunumService.GetPI<VillaGorunumDtoQ>(x => x.VillaId == villa.Villa.Id).FirstOrDefault();
        villa.PeriyodikFiyat = _villaPeriyodikFiyatService
            .GetPI<VillaPeriyodikFiyatDtoQ>(x => x.VillaId == villa.Villa.Id && x.IsDeleted == false).ToList();
        villa.PeriyodikFiyatAyarlari = _villaPeriyodikFiyatAyarlariService
            .GetPI<VillaPeriyodikFiyatAyarlariDtoQ>(x => x.VillaId == villa.Villa.Id).ToList();

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
            Il = x.Villa.VillaLokasyon.FirstOrDefault().Ilce.Il.Ad,
            Ilce = x.Villa.VillaLokasyon.FirstOrDefault().Ilce.Ad,
            Fiyat = x.Villa.PeriyodikFiyat
                .Where(pf => DateTime.Today >= pf.Baslangic.Date  &&  DateTime.Today <= pf.Bitis.Date )
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
        double filterStartPrice,
        double filterEndPrice,
        int filterGuestCount
    )
    {
        var villaQuery = _appDbContext.Villa.Where(v => !v.IsDeleted).AsQueryable();

        if (filterName != null)
        {
            villaQuery = villaQuery
                .Where(i => i.Ad.ToLower().Contains(filterName.ToLower()));
        }
        if (filterGuestCount > -1)
        {
            villaQuery = villaQuery
                .Where(i => i.Kapasite>=filterGuestCount);
        }
        if (filterType.Count > 0)
        {
            villaQuery = villaQuery
                .Where(i => filterType.Contains(i.MulkId));
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
                .Where(i => _appDbContext.VillaKategori.Where(vk => filterCategory.Contains(vk.Id) && vk.VillaId==i.Id && !vk.IsDeleted).Count() == filterCategory.Count());
        }
        if (filterProperty.Count > 0)
        {
            villaQuery = villaQuery
                .Where(i => i.VillaOzellik.Where(vl => !vl.IsDeleted && filterCategory.Contains(vl.Id)).Count() == filterCategory.Count()
                );
        }
        
        var searchResult = villaQuery.Select(x => new VillaDtoFQ
            {
                Id = x.Id,
                Ad = x.Ad,
                Url = x.Url,
                ImageId = x.VillaImage != null ? x.VillaImageDetay.FirstOrDefault().Id : null,
                Il = x.VillaLokasyon.FirstOrDefault().Ilce.Il.Ad,
                Ilce = x.VillaLokasyon.FirstOrDefault().Ilce.Ad,
                Fiyat = x.PeriyodikFiyat
                    .Where(pf => pf.Baslangic.Date >= DateTime.Today && pf.Bitis.Date <= DateTime.Today)
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Kapasite,
                Mevki = x.VillaLokasyon.FirstOrDefault().Mevki,
                BanyoSayisi = x.BanyoSayisi,
                FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.FirstOrDefault().FiyatTuru),
                ParaBirimi = x.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                OdaSayisi = x.OdaSayisi,
                YatakOdaSayisi = x.YatakOdaSayisi
            }).ToList();

        return searchResult;
    }
    
    public List<VillaDtoFQ> GetVillasByIds(VillaIdsFQ rb)
    {
        var villaBolge = _appDbContext.Villa
            .Where(x =>!x.IsDeleted && rb.Ids.Contains(x.Id))
            .Select(x => new VillaDtoFQ
            {
                Id = x.Id,
                Ad = x.Ad,
                Url = x.Url,
                ImageId = x.VillaImage != null ? x.VillaImageDetay.FirstOrDefault().Id : null,

                Fiyat = x.PeriyodikFiyat
                    .Where(pf => DateTime.Today >= pf.Baslangic.Date  &&  DateTime.Today <= pf.Bitis.Date )
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Kapasite,
                BanyoSayisi = x.BanyoSayisi,
                FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.Where(f_ => !f_.IsDeleted).FirstOrDefault().FiyatTuru),
                ParaBirimi = x.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                OdaSayisi = x.OdaSayisi,
                YatakOdaSayisi = x.YatakOdaSayisi
            }).ToList();

        return villaBolge;
    }
    public List<VillaDtoFQ> GetCollectionVillas(Guid key)
    {
        Collections collection = _appDbContext.Collections.FirstOrDefault(c => c.key == key);
        if (collection == null)
        {
            return new List<VillaDtoFQ>();
        }

        var villaIds = _appDbContext.CollectionVillas.Where(v => v.CollectionId == collection.Id).Select(v => v.VillaId).ToList();
        var villas = _appDbContext.Villa
            .Where(x =>!x.IsDeleted && villaIds.Contains(x.Id))
            .Select(x => new VillaDtoFQ
            {
                Id = x.Id,
                Ad = x.Ad,
                Url = x.Url,
                ImageId = x.VillaImage != null ? x.VillaImageDetay.FirstOrDefault().Id : null,

                Fiyat = x.PeriyodikFiyat
                    .Where(pf => DateTime.Today >= pf.Baslangic.Date  &&  DateTime.Today <= pf.Bitis.Date )
                    .FirstOrDefault().Fiyat,
                Kapasite = x.Kapasite,
                BanyoSayisi = x.BanyoSayisi,
                FiyatTuru = EnumHelper<FiyatTuru>.GetDisplayValue(x.PeriyodikFiyat.Where(f_ => !f_.IsDeleted).FirstOrDefault().FiyatTuru),
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
}