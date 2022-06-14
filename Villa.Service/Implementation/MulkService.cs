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

public class MulkService : IMulkService
{
    private readonly IRepository<Domain.Entities.Mulk> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public MulkService(IRepository<Domain.Entities.Mulk> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        List<MulkDtoQ> il = _mapper.Map<List<Mulk>,List<MulkDtoQ>>(_appDbContext.Mulk.ToList());
        // var entity = await _repository.GetAllAsync(x => x.Include(y => y.Il));
        // var bolge =
        //      _mapper.Map<IQueryable<Bolge>,IQueryable<BolgeDtoQ>>(entity);
        return new ResponseModel(il);
    }
    public async Task<ResponseModel> Get(int id)
    {
       var entity = await _repository.GetSingleAsync(x=>x.Id == id);
       return new ResponseModel(_mapper.Map<MulkDtoQ>(entity));
    }
    
    public async Task<ResponseModel> Add(MulkDtoC bolge)
    {  
        var entity = _mapper.Map<Mulk>(bolge);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(MulkDtoC bolge)
    {
        var entity = _mapper.Map<Mulk>(bolge);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.Mulk station = _mapper.Map<Mulk>( Get(id));
        return await _repository.DeleteAsync(station);
    }

  
}