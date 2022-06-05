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
        List<BolgeDtoQ> bolge = _mapper.Map<List<Bolge>,List<BolgeDtoQ>>(_appDbContext.Bolge.Include(x=> x.Il).ToList());
        // var entity = await _repository.GetAllAsync(x => x.Include(y => y.Il));
        // var bolge =
        //      _mapper.Map<IQueryable<Bolge>,IQueryable<BolgeDtoQ>>(entity);
        return new ResponseModel(bolge);
    }
    public async Task<BolgeDtoQ> Get(int id)
    {
       var entity = await _repository.GetSingleAsync(x=>x.Id == id, x=> x.Include(y=> y.Il));
       return _mapper.Map<BolgeDtoQ>(entity);
    }
    
    public async Task<ResponseModel> Add(BolgeDtoC bolge)
    {  
        var entity = _mapper.Map<Bolge>(bolge);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(BolgeDtoC bolge)
    {
        var entity = _mapper.Map<Bolge>(bolge);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.Bolge station = _mapper.Map<Bolge>( Get(id));
        return await _repository.DeleteAsync(station);
    }

  
}