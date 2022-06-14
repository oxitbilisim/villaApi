using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IVillaPeriyodikFiyatService
    {
        Task<ResponseModel> Get(int id); 
        Task<ResponseModel> Add(VillaPeriyodikFiyatDtoC dto);
        Task<ResponseModel> Update(VillaPeriyodikFiyatDtoC dto);
        Task<ResponseModel> Delete(int id);
    }
}
