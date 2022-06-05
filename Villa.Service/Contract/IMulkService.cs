using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IMulkService
    {
        Task<ResponseModel> GetAll();
        Task<MulkDtoQ> Get(int id); 
        Task<ResponseModel> Add(MulkDtoC dto);
        Task<ResponseModel> Update(MulkDtoC dto);
        Task<ResponseModel> Delete(int id);
     }
}
