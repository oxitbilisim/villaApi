
using AutoMapper;
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
}