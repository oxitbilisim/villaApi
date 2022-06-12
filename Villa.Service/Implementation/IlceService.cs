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

public class IlceService : IIlceService
{
    private readonly IRepository<Domain.Entities.Ilce> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public IlceService(IRepository<Domain.Entities.Ilce> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        List<IlceDtoQ> ilce = _mapper.Map<List<Ilce>,List<IlceDtoQ>>(_appDbContext.Ilce.Include(x=> x.Il).ToList());
        // var entity = await _repository.GetAllAsync(x => x.Include(y => y.Il));
        // var bolge =
        //      _mapper.Map<IQueryable<Bolge>,IQueryable<BolgeDtoQ>>(entity);
        return new ResponseModel(ilce);
    }
    public async Task<IlceDtoQ> Get(int id)
    {
       var entity = await _repository.GetSingleAsync(x=>x.Id == id, x=> x.Include(y=> y.Il));
       return _mapper.Map<IlceDtoQ>(entity);
    }
    
    public async Task<IEnumerable<IlceDtoQ>> GetAllAsyncIlId(int id)
    {
        IEnumerable<IlceDtoQ> ilce = _mapper.Map<IEnumerable<Domain.Entities.Ilce>,IEnumerable<IlceDtoQ>>(await _repository.GetWhereAsync(x=>x.IlId == id)); 
        return ilce;
    }
    
    public async Task<ResponseModel> Add(IlceDtoC bolge)
    {  
        var entity = _mapper.Map<Ilce>(bolge);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(IlceDtoC bolge)
    {
        var entity = _mapper.Map<Ilce>(bolge);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.Ilce station = _mapper.Map<Ilce>( Get(id));
        return await _repository.DeleteAsync(station);
    }

  
}