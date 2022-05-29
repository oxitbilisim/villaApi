using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;

namespace Villa.Service.Contract
{
    public interface IBolgeService
    {
        Task<ResponseModel> GetAll();
        Task<Bolge> GetBolge(int id);
        Task AddBolge(BolgeDtoC bolge);
        void UpdateBolge(BolgeDtoC bolge);
        void DeleteBolge(int id);
     }
}
