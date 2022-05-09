using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Interfaces;
using Villa.Persistence;
using Villa.Service.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Service.Implementation
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

        public async Task<List<SorumlulukAlaniDto>> GetAllChildren(Guid? parentId)
        {

            var sorumlulukalani = _appDbContext.SorumlulukAlani.ToList();
            var std = GetChildren(sorumlulukalani, parentId);

            return new List<SorumlulukAlaniDto>(std);
        }

        public List<int> GetAllChild(int id, List<KeyValuePair<int, int>> newLst)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < newLst.Count; i++)
            {
                if (Convert.ToInt32(newLst[i].Key) == id)
                {
                    if (!list.Contains(Convert.ToInt32(newLst[i].Value)))
                    {
                        list.Add(Convert.ToInt32(newLst[i].Value));
                        List<int> l = GetAllChild(newLst[i].Value, newLst);
                        list.AddRange(l);
                    }
                }
            }
            return list;
        }

        public List<SorumlulukAlaniDto> GetChildren(List<Domain.Entities.SorumlulukAlani> sorumlulukalanis, Guid? parentId)
        {
            return sorumlulukalanis
                    .Where(c => c.ParentSorumlulukAlaniId == parentId)
                    .Select(c => new SorumlulukAlaniDto
                    {
                        title = c.Tanim,
                        value = c.Id,
                        key = c.Id,
                        children = GetChildren(sorumlulukalanis, c.Id)
                    })
                    .ToList();
        }
      
        public async Task<Domain.Entities.SorumlulukAlani> GetSorumlulukAlaniAsync(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public async void InsertSorumlulukAlani(Domain.Entities.SorumlulukAlani sorumlulukAlani)
        {
            await _repository.CreateAsync(sorumlulukAlani);
        }
        public async void UpdateSorumlulukAlani(Domain.Entities.SorumlulukAlani sorumlulukAlani)
        {
            await _repository.UpdateAsync(sorumlulukAlani);
        }

        public async void DeleteSorumlulukAlani(Guid id)
        {
            Domain.Entities.SorumlulukAlani sorumlulukAlani = await GetSorumlulukAlaniAsync(id);
            _repository.DeleteAsync(sorumlulukAlani);
        }
    }
}
