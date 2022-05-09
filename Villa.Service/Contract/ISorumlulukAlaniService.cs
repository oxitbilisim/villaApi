using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Villa.Service.Contract
{
    public interface ISorumlulukAlaniService
    {
        Task<ResponseModel> GetAllAsync();
        Task<List<SorumlulukAlaniDto>> GetAllChildren(Guid? parentId);
        Task<SorumlulukAlani> GetSorumlulukAlaniAsync(Guid id);
        void InsertSorumlulukAlani(SorumlulukAlani sorumlulukalani);
        void UpdateSorumlulukAlani(SorumlulukAlani sorumlulukalani);
        void DeleteSorumlulukAlani(Guid id);
    }
}
