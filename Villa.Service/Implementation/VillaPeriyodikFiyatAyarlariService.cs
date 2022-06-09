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

public class VillaPeriyodikFiyatAyarlariService : IVillaPeriyodikFiyatAyarlariService
{
    private readonly IRepository<Domain.Entities.PeriyodikFiyatAyarlari> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public VillaPeriyodikFiyatAyarlariService(IRepository<Domain.Entities.PeriyodikFiyatAyarlari> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    public async Task<Domain.Entities.PeriyodikFiyatAyarlari> Get(int id)
    {
        //return await _repository.GetAsync(id);
        return await _repository.GetSingleAsync(x=>x.VillaId == id);
    }
    public async Task<ResponseModel> Add(VillaPeriyodikFiyatAyarlariDtoC data)
    {  
        var entity = _mapper.Map<Domain.Entities.PeriyodikFiyatAyarlari>(data);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(VillaPeriyodikFiyatAyarlariDtoC data)
    {
        var entity = _mapper.Map<Domain.Entities.PeriyodikFiyatAyarlari>(data);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.PeriyodikFiyatAyarlari data = await Get(id);
        return await _repository.DeleteAsync(data);
    }

  
}