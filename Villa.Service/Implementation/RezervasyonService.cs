
using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Persistence;
using Villa.Service.Base;
namespace Villa.Service.Implementation;

public class RezervasyonService : BaseService<Domain.Entities.Rezervasyon>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    public RezervasyonService( appDbContext appDbContext,
        IMapper mapper) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public ResponseModel MuhasebeCalculate()
    {
         var muhasebe = _appDbContext.RezervasyonMaliBilgi.
             Include(y=> y.Rezervasyon)
             .Select(x=> new 
                 {
                     ToplamTutar =  x.ToplamTutar, 
                     KomisyonOran = x.Komisyon,
                     ToplamTutars = (x.ToplamTutar * x.Komisyon) / 100,
                     RezervasyonId = x.RezervasyonId,
                     VillaId = x.Rezervasyon.VillaId
                  }
             )
         .ToList();
            
       return new ResponseModel(muhasebe);
    }
}