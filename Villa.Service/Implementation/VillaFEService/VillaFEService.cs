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
    public VillaFEService( appDbContext appDbContext,
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
        var bolge = _appDbContext.Bolge.Where(x=> !x.IsDeleted).Select(x => new BolgeDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            Image = rules == 1 ? x.Image : null,
            Toplam = _appDbContext.VillaLokasyon.Where(y => y.BolgeId == x.Id && x.IsDeleted).Count()
        }).ToList();
        return bolge;
    }
    
    public List<VillaDtoFQ> GetBolgeVillas(int bolgeId)
    {
        var villaBolge = _appDbContext.VillaLokasyon
                                                           .Where(x=> x.BolgeId == bolgeId)
                                                           .Select(x => new VillaDtoFQ
        {
            Id = x.Id,
            Ad = x.Villa.Ad,
            Url = x.Villa.Url,
            Image = x.Villa.VillaImage != null ? x.Villa.VillaImageDetay.FirstOrDefault().Image : null,
            Il = x.Ilce.Il.Ad,
            Ilce = x.Ilce.Ad,
            Fiyat = x.Villa.PeriyodikFiyat.Where(pf=> pf.Baslangic.Date>= DateTime.Today && pf.Bitis.Date <= DateTime.Today ).FirstOrDefault().Fiyat,
            Kapasite = x.Villa.Kapasite,
            Mevki = x.Mevki,
            BanyoSayisi = x.Villa.BanyoSayisi,
            FiyatTuru =  EnumHelper<FiyatTuru>.GetDisplayValue(x.Villa.PeriyodikFiyat.FirstOrDefault().FiyatTuru) ,
            ParaBirimi = x.Villa.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
            OdaSayisi = x.Villa.OdaSayisi,
            YatakOdaSayisi = x.Villa.YatakOdaSayisi
        }).ToList();
   
        return villaBolge;
    }
  
    public List<KategoriDtoFQ> GetKategori(int rules)
    {
        var kategori = _appDbContext.Kategori.Where(x=> !x.IsDeleted).Select(x=> new KategoriDtoFQ
        {
            Id = x.Id,
            Ad   = x.Ad,
            Url = x.Url,
            Image = rules == 1 ? x.Image : null,
            Toplam = _appDbContext.VillaKategori.Where(y=> y.KategoriId == x.Id && y.IsDeleted).Count()
        }).ToList();
        
        return kategori;
    }
    
    public List<VillaDtoFQ> GetKategoriVillas(int kategoriId)
    {
        var villaKategori = _appDbContext.VillaKategori
            .Where(x=> x.KategoriId == kategoriId && !x.IsDeleted)
            .Select(x => new VillaDtoFQ
            {
                Id = x.Id,
                Ad = x.Villa.Ad,
                Url = x.Villa.Url,
                Image = x.Villa.VillaImage != null ? x.Villa.VillaImageDetay.FirstOrDefault().Image : null,
                Il = x.Villa.VillaLokasyon.FirstOrDefault().Ilce.Il.Ad,
                Ilce = x.Villa.VillaLokasyon.FirstOrDefault().Ilce.Ad,
                Fiyat = x.Villa.PeriyodikFiyat.Where(pf=> pf.Baslangic.Date>= DateTime.Today && pf.Bitis.Date <= DateTime.Today ).FirstOrDefault().Fiyat,
                Kapasite = x.Villa.Kapasite,
                Mevki = x.Villa.VillaLokasyon.FirstOrDefault().Mevki,
                BanyoSayisi = x.Villa.BanyoSayisi,
                FiyatTuru =  EnumHelper<FiyatTuru>.GetDisplayValue(x.Villa.PeriyodikFiyat.FirstOrDefault().FiyatTuru) ,
                ParaBirimi = x.Villa.PeriyodikFiyat.FirstOrDefault().ParaBirimi.Ad,
                OdaSayisi = x.Villa.OdaSayisi,
                YatakOdaSayisi = x.Villa.YatakOdaSayisi
            }).ToList();
   
        return villaKategori;
    }
    
    public VillaFullDtoFQ GetVillaById(int villaId)
    {
        VillaFullDtoFQ villa = new();
        villa.Villa = _villaService.GetAllPI<VillaDtoQ>(x => x.IsDeleted == false).FirstOrDefault();
        villa.Images = _villaImageDetayService.GetPI<VillaImageDetayDtoQ>(x => x.VillaId == villaId).ToList();
        villa.Lokasyon = _villaLokasyonService.GetPI<VillaLokasyonDtoQ>(x => x.VillaId == villaId).FirstOrDefault();
        villa.Icerik = _villaIcerikService.GetPI<VillaIcerikDtoQ>(x => x.VillaId == villaId).FirstOrDefault();
        villa.Kategori = _villaKategoriService.GetPI<VillaKategoriDtoQ>(x=> x.VillaId == villaId).ToList();
        villa.Ozellik = _villaOzellikService.GetPI<VillaOzellikDtoQ>(x=> x.VillaId == villaId).ToList();
        villa.Gorunum = _villaGorunumService.GetPI<VillaGorunumDtoQ>(x=> x.VillaId == villaId).FirstOrDefault();
        villa.PeriyodikFiyat = _villaPeriyodikFiyatService.GetPI<VillaPeriyodikFiyatDtoQ>(x=> x.VillaId == villaId  && x.IsDeleted == false).ToList();
        villa.PeriyodikFiyatAyarlari = _villaPeriyodikFiyatAyarlariService.GetPI<VillaPeriyodikFiyatAyarlariDtoQ>(x=> x.VillaId == villaId).ToList();
   
        return villa;
    }
    
    
}