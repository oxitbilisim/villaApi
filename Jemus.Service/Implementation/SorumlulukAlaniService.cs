using Jemus.Domain.Common;
using Jemus.Domain.Dtos;
using Jemus.Domain.Interfaces;
using Jemus.Persistence;
using Jemus.Service.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jemus.Service.Implementation
{
    public class SorumlulukAlaniService : ISorumlulukAlaniService
    {
        private readonly IRepository<Domain.Entities.SorumlulukAlani> _repository;
        private readonly IAppDbContext _appDbContext;

        public SorumlulukAlaniService(IRepository<Domain.Entities.SorumlulukAlani> repository,
                                      IAppDbContext appDbContext)
        {
            _repository = repository;
            _appDbContext = appDbContext;
        }

        public async Task<ResponseModel> GetAllAsync()
        {
            var sorumlulukalani = _appDbContext.SorumlulukAlani.ToList();
            var std = GetChildren(sorumlulukalani, null);

            return new ResponseModel(std);
        }

        public List<SorumlulukAlaniDto> GetChildren(List<Domain.Entities.SorumlulukAlani> sorumlulukalanis, Guid? parentId)
        {
            return sorumlulukalanis
                    .Where(c => c.ParentSorumlulukAlaniId == parentId)
                    .Select(c => new SorumlulukAlaniDto
                    {
                        Id = c.Id,
                        title = c.Tanim,
                        ParentSorumlulukAlaniId = c.ParentSorumlulukAlaniId,
                        children = GetChildren(sorumlulukalanis, c.Id)
                    })
                    .ToList();
        }
      
        public async Task<Domain.Entities.SorumlulukAlani> GetSorumlulukAlaniAsync(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public async void InsertCustomer(Domain.Entities.SorumlulukAlani sorumlulukAlani)
        {
            await _repository.CreateAsync(sorumlulukAlani);
        }
        public async void UpdateCustomer(Domain.Entities.SorumlulukAlani sorumlulukAlani)
        {
            await _repository.UpdateAsync(sorumlulukAlani);
        }

        public async void DeleteCustomer(Guid id)
        {
            Domain.Entities.SorumlulukAlani sorumlulukAlani = await GetSorumlulukAlaniAsync(id);
            _repository.DeleteAsync(sorumlulukAlani);
        }
    }
}
