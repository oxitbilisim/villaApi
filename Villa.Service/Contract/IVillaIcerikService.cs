using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IVillaIcerikService
    {
        Task<Domain.Entities.VillaIcerik> Get(int id); 
        Task<ResponseModel> Add(VillaIcerikDtoC dto);
        Task<ResponseModel> Update(VillaIcerikDtoC dto);
        Task<ResponseModel> Delete(int id);
    }
}
