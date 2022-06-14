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

public class VillaPeriyodikFiyatService : IVillaPeriyodikFiyatService
{
    private readonly IRepository<Domain.Entities.PeriyodikFiyat> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public VillaPeriyodikFiyatService(IRepository<Domain.Entities.PeriyodikFiyat> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    public async Task<ResponseModel> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.VillaId == id, x=> x.Include(y=> y.Villa));
        return new ResponseModel(_mapper.Map<VillaIcerikDtoQ>(entity));
    }
    public async Task<ResponseModel> Add(VillaPeriyodikFiyatDtoC data)
    {  
        var entity = _mapper.Map<Domain.Entities.PeriyodikFiyat>(data);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(VillaPeriyodikFiyatDtoC data)
    {
        var entity = _mapper.Map<Domain.Entities.PeriyodikFiyat>(data);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        PeriyodikFiyat station = _mapper.Map<PeriyodikFiyat>( Get(id));
        return await _repository.DeleteAsync(station);
    }

  
}