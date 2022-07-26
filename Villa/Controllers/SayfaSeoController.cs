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
    [Route("api/SayfaSeo")]
    public class SayfaSeoController : ControllerBase, IDisposable
    {
        private readonly SayfaSeoService _sayfaSeoService;
        public SayfaSeoController(SayfaSeoService sayfaSeoService)
        {
            _sayfaSeoService = sayfaSeoService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _sayfaSeoService.GetPI<SayfaSeoDtoQ>(x=> x.SayfaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetIcerikSayfaById))]
        public ResponseModel GetIcerikSayfaById(int id)
        {
            var result =  _sayfaSeoService.GetPI<SayfaSeoDtoQ>(x=> x.SayfaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(SayfaSeoDtoC dto)
        { 
            return  new ResponseModel(_sayfaSeoService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(SayfaSeoDtoC dto)
        {
            return  new ResponseModel(_sayfaSeoService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_sayfaSeoService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}