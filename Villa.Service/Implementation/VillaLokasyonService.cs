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
using Villa.Service.Contract;

namespace Villa.Service.Implementation;

public class VillaLokasyonService : IVillaLokasyonService
{
    private readonly IRepository<Domain.Entities.VillaLokasyon> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public VillaLokasyonService(IRepository<Domain.Entities.VillaLokasyon> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    public async Task<Domain.Entities.VillaLokasyon> Get(int id)
    {
        //return await _repository.GetAsync(id);
        return await _repository.GetSingleAsync(x=>x.Id == id, x=> x.Include(y=> y.Villa));
    }
    public async Task<ResponseModel> Add(VillaLokasyonDtoC data)
    {  
        var entity = _mapper.Map<Domain.Entities.VillaLokasyon>(data);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(VillaLokasyonDtoC data)
    {
        var entity = _mapper.Map<Domain.Entities.VillaLokasyon>(data);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.VillaLokasyon data = await Get(id);
        return await _repository.DeleteAsync(data);
    }

  
}