using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IVillaLokasyonService
    {
        Task<Domain.Entities.VillaLokasyon> Get(int id); 
        Task<ResponseModel> Add(VillaLokasyonDtoC dto);
        Task<ResponseModel> Update(VillaLokasyonDtoC dto);
        Task<ResponseModel> Delete(int id);
    }
}
