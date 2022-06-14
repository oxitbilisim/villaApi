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

public class VillaImageService : IVillaImageService
{
    private readonly IRepository<Domain.Entities.VillaImage> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public VillaImageService(IRepository<Domain.Entities.VillaImage> repository, 
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
    public async Task<ResponseModel> Add(VillaImageDtoC data)
    {  
        var entity = _mapper.Map<Domain.Entities.VillaImage>(data);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(VillaImageDtoC data)
    {
        var entity = _mapper.Map<Domain.Entities.VillaImage>(data);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.VillaImage station = _mapper.Map<VillaImage>( Get(id).Result.Data);
        return await _repository.DeleteAsync(station);
    }

  
}