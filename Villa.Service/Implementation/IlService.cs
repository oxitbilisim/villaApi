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

public class IlService : IIlService
{
    private readonly IRepository<Domain.Entities.Il> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public IlService(IRepository<Domain.Entities.Il> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        List<IlDtoQ> il = _mapper.Map<List<Il>,List<IlDtoQ>>(_appDbContext.Il.ToList());
        // var entity = await _repository.GetAllAsync(x => x.Include(y => y.Il));
        // var bolge =
        //      _mapper.Map<IQueryable<Bolge>,IQueryable<BolgeDtoQ>>(entity);
        return new ResponseModel(il);
    }
    public async Task<IlDtoQ> Get(int id)
    {
       var entity = await _repository.GetSingleAsync(x=>x.Id == id);
       return _mapper.Map<IlDtoQ>(entity);
    }
    
    public async Task<ResponseModel> Add(IlDtoC bolge)
    {  
        var entity = _mapper.Map<Il>(bolge);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(IlDtoC bolge)
    {
        var entity = _mapper.Map<Il>(bolge);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.Il station = _mapper.Map<Il>( Get(id));
        return await _repository.DeleteAsync(station);
    }

  
}