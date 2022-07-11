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
    public VillaFEService( appDbContext appDbContext,
           IMapper mapper) 
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public List<BolgeDtoFQ> GetBolge(int rules)
    {
        var bolge = _appDbContext.Bolge.Select(x => new BolgeDtoFQ
        {
            Id = x.Id,
            Ad = x.Ad,
            Url = x.Url,
            Image = rules == 1 ? x.Image : null,
            Toplam = _appDbContext.VillaLokasyon.Where(y => y.BolgeId == x.Id).Count()
        }).ToList();
        return bolge;
    }
    
    public List<VillaDtoFQ> GetBolgeVillas(string BolgeAd)
    {
        var villaBolge = _appDbContext.VillaLokasyon
                                                           .Where(x=> x.Bolge.Ad == BolgeAd)
                                                           .Select(x => new VillaDtoFQ
        {
            Id = x.Id,
            Ad = x.Villa.Ad,
            Url = x.Villa.Url,
            Image = x.Villa.VillaImage != null ? x.Villa.VillaImage.FirstOrDefault().Image : null,
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
        var kategori = _appDbContext.Kategori.Select(x=> new KategoriDtoFQ
        {
            Id = x.Id,
            Ad   = x.Ad,
            Url = x.Url,
            Image = rules == 1 ? x.Image : null,
            Toplam = _appDbContext.VillaKategori.Where(y=> y.KategoriId == x.Id).Count()
        }).ToList();
        
        return kategori;
    }
    
    public List<VillaDtoFQ> GetKategoriVillas(string kategoriAd)
    {
        var villaKategori = _appDbContext.VillaKategori
            .Where(x=> x.Kategori.Ad == kategoriAd)
            .Select(x => new VillaDtoFQ
            {
                Id = x.Id,
                Ad = x.Villa.Ad,
                Url = x.Villa.Url,
                Image = x.Villa.VillaImage != null ? x.Villa.VillaImage.FirstOrDefault().Image : null,
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
    
    
    
}