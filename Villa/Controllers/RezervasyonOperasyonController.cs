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
    [Route("api/RezervasyonOperasyon")]
    public class RezervasyonOperasyonController : ControllerBase
    {
        private readonly RezervasyonOperasyonService _rezervasyonOperasyonService;

        public RezervasyonOperasyonController(RezervasyonOperasyonService rezervasyonOperasyonService)
        {
            _rezervasyonOperasyonService = rezervasyonOperasyonService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _rezervasyonOperasyonService.GetAllPI<RezervasyonOperasyonQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _rezervasyonOperasyonService.GetPI<RezervasyonOperasyonQ>(x=> x.RezervasyonId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public  ActionResult<ResponseModel> Add(RezervasyonOperasyonC dto)
        { 
            return new ResponseModel(_rezervasyonOperasyonService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(RezervasyonOperasyonC dto)
        {
            return new ResponseModel( _rezervasyonOperasyonService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            return new ResponseModel( _rezervasyonOperasyonService.Delete(Id));
        }
    }
}