using Jemus.Domain.Common;
using Jemus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jemus.Service.Contract
{
    public interface ISorumlulukAlaniService
    {
        Task<ResponseModel> GetAllAsync();
        Task<SorumlulukAlani> GetSorumlulukAlaniAsync(Guid id);
        void InsertCustomer(SorumlulukAlani customer);
        void UpdateCustomer(SorumlulukAlani customer);
        void DeleteCustomer(Guid id);
    }
}
