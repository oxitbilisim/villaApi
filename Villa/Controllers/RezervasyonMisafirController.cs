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
    [Route("api/RezervasyonMisafir")]
    public class RezervasyonMisafirController : ControllerBase
    {
        private readonly RezervasyonMisafirService _rezervasyoMisafirService;

        public RezervasyonMisafirController(RezervasyonMisafirService rezervasyoMisafirService)
        {
            _rezervasyoMisafirService = rezervasyoMisafirService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _rezervasyoMisafirService.GetAllPI<RezervasyonMisafirQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _rezervasyoMisafirService.GetPI<RezervasyonMisafirQ>(x=> x.RezervasyonId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public  ActionResult<ResponseModel> Add(RezervasyonMisafirC dto)
        { 
            return new ResponseModel(_rezervasyoMisafirService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(RezervasyonMisafirC dto)
        {
            return new ResponseModel( _rezervasyoMisafirService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            return new ResponseModel( _rezervasyoMisafirService.Delete(Id));
        }
    }
}