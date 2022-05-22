using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;
using Villa.Persistence;
using Villa.Service.Contract;

namespace Villa.Service.Implementation;

public class BolgeService : IBolgeService
{
    private readonly IRepository<Domain.Entities.Bolge> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public BolgeService(IRepository<Domain.Entities.Bolge> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        var bolge = _appDbContext.Bolge.ToList();
        return new ResponseModel(bolge);
    }
    public async Task<Domain.Entities.Bolge> GetBolge(int id)
    {
        return await _repository.GetAsync(id);
    }
    
    public async Task AddBolge(BolgeDto bolge)
    {  
        var entity = _mapper.Map<Bolge>(bolge);
        await _repository.AddAsync(entity);
    }
    public async void UpdateBolge(Domain.Entities.Bolge bolge)
    {
        await _repository.UpdateAsync(bolge);
    }
    
    public async void DeleteBolge(int id)
    {
        Domain.Entities.Bolge station = await GetBolge(id);
        _repository.DeleteAsync(station);
    }

  
}