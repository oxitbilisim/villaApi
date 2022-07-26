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
    [Route("api/SayfaIcerik")]
    public class SayfaIcerikController : ControllerBase, IDisposable
    {
        private readonly SayfaIcerikService _sayfaIcerikService;
        public SayfaIcerikController(SayfaIcerikService sayfaIcerikService)
        {
            _sayfaIcerikService = sayfaIcerikService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _sayfaIcerikService.GetPI<SayfaIcerikDtoQ>(x=> x.SayfaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetIcerikSayfaById))]
        public ResponseModel GetIcerikSayfaById(int id)
        {
            var result =  _sayfaIcerikService.GetPI<SayfaIcerikDtoQ>(x=> x.SayfaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(SayfaIcerikDtoC dto)
        { 
            return  new ResponseModel(_sayfaIcerikService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(SayfaIcerikDtoC dto)
        {
            return  new ResponseModel(_sayfaIcerikService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_sayfaIcerikService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}