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

public class BolgeService : BaseService<Bolge>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    public BolgeService( appDbContext appDbContext,
           IMapper mapper) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public List<BolgeDtoFQ> GetBolgeFE()
    {
        var bolge = _appDbContext.Bolge.Select(x=> new BolgeDtoFQ
        {
            Ad     = x.Ad,
            Url = x.Url,
            Image = x.Image,
            Toplam = _appDbContext.VillaLokasyon.Where(y=> y.BolgeId == x.Id).Sum(z=> z.VillaId)
        }).ToList();
        
        return bolge;
    }
}