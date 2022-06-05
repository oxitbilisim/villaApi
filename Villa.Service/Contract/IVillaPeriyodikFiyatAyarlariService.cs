using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IVillaPeriyodikFiyatAyarlariService
    {
        Task<Domain.Entities.PeriyodikFiyatAyarlari> Get(int id); 
        Task<ResponseModel> Add(VillaPeriyodikFiyatAyarlariDtoC dto);
        Task<ResponseModel> Update(VillaPeriyodikFiyatAyarlariDtoC dto);
        Task<ResponseModel> Delete(int id);
    }
}
