using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/RezervasyonMaliBilgi")]
    public class RezervasyonMaliBilgiController : ControllerBase
    {
        private readonly RezervasyonMaliBilgiService _rezervasyonMaliBilgiService;

        public RezervasyonMaliBilgiController(RezervasyonMaliBilgiService rezervasyonMaliBilgiService)
        {
            _rezervasyonMaliBilgiService = rezervasyonMaliBilgiService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _rezervasyonMaliBilgiService.GetAllPI<RezervasyonMaliBilgiQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _rezervasyonMaliBilgiService.GetPI<RezervasyonMaliBilgiQ>(x=> x.RezervasyonId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public  ActionResult<ResponseModel> Add(RezervasyonMaliBilgiC dto)
        { 
            return new ResponseModel(_rezervasyonMaliBilgiService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(RezervasyonMaliBilgiC dto)
        {
            return new ResponseModel( _rezervasyonMaliBilgiService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            return new ResponseModel( _rezervasyonMaliBilgiService.Delete(Id));
        }

        [HttpGet(nameof(VillaMaliBilgi))]
        public ActionResult<ResponseModel> VillaMaliBilgi(int id)
        {
            return _rezervasyonMaliBilgiService.villaMaliBilgi(id);
        }
    }
}