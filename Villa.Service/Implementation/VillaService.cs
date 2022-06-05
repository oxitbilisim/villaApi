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

public class VillaService : IVillaService
{
    private readonly IRepository<Domain.Entities.Villa> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public VillaService(IRepository<Domain.Entities.Villa> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        List<VillaDtoQ> villa = _mapper.Map<List<Domain.Entities.Villa>,List<VillaDtoQ>>(_appDbContext.Villa.Include(x=> x.Mulk).ToList());
        return new ResponseModel(villa);
    }
    public async Task<Domain.Entities.Villa> Get(int id)
    {
        //return await _repository.GetAsync(id);
        return await _repository.GetSingleAsync(x=>x.Id == id);
    }
    
    public async Task<ResponseModel> Add(VillaDtoC data)
    {  
        var entity = _mapper.Map<Domain.Entities.Villa>(data);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(VillaDtoC data)
    {
        var entity = _mapper.Map<Domain.Entities.Villa>(data);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.Villa data = await Get(id);
        return await _repository.DeleteAsync(data);
    }

  
}