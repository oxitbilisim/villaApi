using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IVillaService
    {
        Task<ResponseModel> GetAll();
        Task<Domain.Entities.Villa> Get(int id); 
        Task<ResponseModel> Add(VillaDtoC dto);
        Task<ResponseModel> Update(VillaDtoC dto);
        Task<ResponseModel> Delete(int id);
    }
}
