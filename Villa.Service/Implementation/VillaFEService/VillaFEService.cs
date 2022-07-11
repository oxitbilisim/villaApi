using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Entities;
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
    
    public List<BolgeDtoFQ> GetBolgeFE(int rules)
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
  
    public List<KategoriDtoFQ> GetKategoriFE(int rules)
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
}