
using AutoMapper;
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
}