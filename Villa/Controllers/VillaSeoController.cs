using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Threading.Tasks;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/VillaSeo")]
    public class VillaSeoController : ControllerBase, IDisposable
    {
        private readonly VillaSeoService _villaSeoService;
        public VillaSeoController(VillaSeoService villaSeoService)
        {
            _villaSeoService = villaSeoService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaSeoService.GetPI<VillaSeoDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetSeoVillaById))]
        public ResponseModel GetSeoVillaById(int id)
        {
            var result =  _villaSeoService.GetPI<VillaSeoDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaSeoDtoC dto)
        { 
            return  new ResponseModel(_villaSeoService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaSeoDtoC dto)
        {
            return  new ResponseModel(_villaSeoService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaSeoService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}