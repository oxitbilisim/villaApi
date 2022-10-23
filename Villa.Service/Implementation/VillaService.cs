
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Villa.Domain.Common;
using Villa.Persistence;
using Villa.Service.Base;
namespace Villa.Service.Implementation;

public class VillaService : BaseService<Domain.Entities.Villa>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    public VillaService( appDbContext appDbContext,
        IMapper mapper) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }

    public ResponseModel villaGelAll()
    {
        var villa = _appDbContext.Villa.Where(X=>X.IsDeleted==false).Select(y => new
        {
                id=y.Id,
                active=y.Active,
                mulkAd=y.Mulk.Ad,
                ad=y.Ad,
            kapasite=y.Kapasite,
                bolge = _appDbContext.VillaLokasyon.Where(x => x.VillaId == y.Id).FirstOrDefault().Bolge.Ad
    }
       ).ToList();
        return new ResponseModel(villa);
    }

}