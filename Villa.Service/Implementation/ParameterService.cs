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
using Villa.Service.Base;
using Villa.Service.Contract;

namespace Villa.Service.Implementation;


    public class ParameterService : BaseService<Parameters>
    {
        private readonly IMapper _mapper;
        private readonly appDbContext _appDbContext;
        public ParameterService( appDbContext appDbContext,
            IMapper mapper) :  base(appDbContext, mapper)
        {
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

    public async Task<ResponseModel> GetAllParameter()
    {
        var parameters = _appDbContext.Parameters.ToList();

        return new ResponseModel(parameters);
    }
    public async Task<ResponseModel> DeleteParameter(int id)
    {
        var parameters = _appDbContext.Parameters.Where(x=>x.Id==id).FirstOrDefault();
        _appDbContext.Parameters.Remove(parameters);
        _appDbContext.SaveChanges();
        return new ResponseModel(Message: "Baþarýyla Silindi", true);
    }

    public async Task<ResponseModel> UpdateParameter(Parameters parameter)
    {
        var parameters = _appDbContext.Parameters.Update(parameter);
            _appDbContext.SaveChanges();
        return new ResponseModel(Message: "Baþarýyla Silindi", true);
    }

    public async Task<ResponseModel> AddParameter(Parameters parameter)
    {
        var parameters = _appDbContext.Parameters.Add(parameter);
        _appDbContext.SaveChanges();
        return new ResponseModel(parameters);
    }
}