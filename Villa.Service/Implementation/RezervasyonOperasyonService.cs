
using AutoMapper;
using Villa.Persistence;
using Villa.Service.Base;
namespace Villa.Service.Implementation;

public class RezervasyonOperasyonService : BaseService<Domain.Entities.RezervasyonOperasyon>
{
    private readonly IMapper _mapper;
    private readonly appDbContext _appDbContext;
    public RezervasyonOperasyonService( appDbContext appDbContext,
        IMapper mapper) :  base(appDbContext, mapper)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
}