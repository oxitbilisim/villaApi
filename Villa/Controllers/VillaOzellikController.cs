using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/VillaOzellik")]
    public class VillaOzellikController : ControllerBase, IDisposable
    {
        private readonly VillaOzellikService _villaOzellikService;
        public VillaOzellikController(VillaOzellikService villaOzellikService)
        {
            _villaOzellikService = villaOzellikService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaOzellikService.GetPI<VillaOzellikDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetOzellikVillaById))]
        public ResponseModel GetOzellikVillaById(int id)
        {
            var result =  _villaOzellikService.GetPI<VillaOzellikDtoQ>(x=> x.VillaId == id).OrderBy(x=> x.OzellikAd);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaOzellikDtoC dto)
        { 
            return  new ResponseModel(_villaOzellikService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaOzellikDtoC dto)
        {
            return  new ResponseModel(_villaOzellikService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaOzellikService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}