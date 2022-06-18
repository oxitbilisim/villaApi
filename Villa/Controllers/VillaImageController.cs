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
    [ApiController]
    [Route("api/VillaImage")]
    public class VillaImageController : ControllerBase, IDisposable
    {
        private readonly VillaImageService _villaImageService;

        public VillaImageController(VillaImageService villaImageService)
        {
            _villaImageService = villaImageService;
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaImageService.Get(id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetVillaById))]
        public ResponseModel GetVillaById(int id)
        {
            var result =  _villaImageService.GetPI<VillaImageDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaImageDtoC dto)
        { 
            return  new ResponseModel(_villaImageService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaImageDtoC dto)
        {
            return  new ResponseModel(_villaImageService.Update(dto)); ;
        }
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaImageService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}