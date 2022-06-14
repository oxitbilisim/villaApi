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

public class VillaIcerikService : IVillaIcerikService
{
    private readonly IRepository<Domain.Entities.VillaIcerik> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public VillaIcerikService(IRepository<Domain.Entities.VillaIcerik> repository, 
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
    
    public async Task<ResponseModel> Add(VillaIcerikDtoC data)
    {  
        var entity = _mapper.Map<Domain.Entities.VillaIcerik>(data);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(VillaIcerikDtoC data)
    {
        var entity = _mapper.Map<Domain.Entities.VillaIcerik>(data);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.VillaIcerik station = _mapper.Map<VillaIcerik>( Get(id));
        return await _repository.DeleteAsync(station);
    }
}