
using AutoMapper;
using Villa.Persistence;
using Villa.Service.Base;
namespace Villa.Service.Implementation;

public class RezervasyonMisafirService : BaseService<Domain.Entities.RezervasyonMisafir>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    public RezervasyonMisafirService( appDbContext appDbContext,
        IMapper mapper) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
}