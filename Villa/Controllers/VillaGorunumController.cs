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
    [Route("api/VillaGorunum")]
    public class VillaGorunumController : ControllerBase, IDisposable
    {
        private readonly VillaGorunumService _villaGorunumService;
        public VillaGorunumController(VillaGorunumService villaGorunumService)
        {
            _villaGorunumService = villaGorunumService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaGorunumService.GetPI<VillaGorunumDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetGorunumVillaById))]
        public ResponseModel GetGorunumVillaById(int id)
        {
            var result =  _villaGorunumService.GetPI<VillaGorunumDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaGorunumDtoC dto)
        { 
            return  new ResponseModel(_villaGorunumService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaGorunumDtoC dto)
        {
            return  new ResponseModel(_villaGorunumService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaGorunumService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}