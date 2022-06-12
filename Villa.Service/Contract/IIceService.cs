using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IIlceService
    {
        Task<ResponseModel> GetAll();
        Task<IlceDtoQ> Get(int id);
        Task<ResponseModel> GetAllAsyncIlId(int id);
        Task<ResponseModel> Add(IlceDtoC dto);
        Task<ResponseModel> Update(IlceDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}
