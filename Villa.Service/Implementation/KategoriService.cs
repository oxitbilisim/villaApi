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

public class KategoriService : IKategoriService
{
    private readonly IRepository<Domain.Entities.Kategori> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    public KategoriService(IRepository<Domain.Entities.Kategori> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        List<KategoriDtoQ> data = _mapper.Map<List<Kategori>,List<KategoriDtoQ>>(_appDbContext.Kategori.ToList());
        return new ResponseModel(data);
    }
    public async Task<Kategori> Get(int id)
    {
        return await _repository.GetAsync(id);
    }
    
    public async Task<ResponseModel> Add(KategoriDtoC dto)
    {  
        var entity = _mapper.Map<Kategori>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(KategoriDtoC dto)
    {
        var entity = _mapper.Map<Kategori>(dto);
        return await _repository.UpdateAsync(entity);
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        Kategori data = await Get(id);
        return await _repository.DeleteAsync(data);
    }

  
}