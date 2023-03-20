using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Enum;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Rezervasyon")]
    public class RezervasyonController : ControllerBase
    {
        private readonly RezervasyonService _rezervasyonService;

        public RezervasyonController(RezervasyonService rezervasyonService)
        {
            _rezervasyonService = rezervasyonService;
        }


        [HttpPost(nameof(UpdateBildirim))]
        public async Task<IActionResult> UpdateBildirim(int Id)
        {
            var result = await _rezervasyonService.UpdateBildirim(Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Error");
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonDtoQ>(x=> x.IsDeleted == false).OrderByDescending(x=> x.Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetRezervation))]
        public IActionResult GetRezervation()
        {
            var result = _rezervasyonService.GetAllPI<RezervasyonDtoQ>(x => x.IsDeleted == false && x.RezervasyonDurum ==RezervasyonDurum.Onayli || x.RezervasyonDurum == RezervasyonDurum.Opsiyon).OrderByDescending(x => x.Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetBildirim))]
        public IActionResult GetBildirim()
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonDtoQ>(x=> x.IsDeleted == false && x.OpenState==false && (x.RezervasyonDurum == RezervasyonDurum.Onayli || x.RezervasyonDurum == RezervasyonDurum.IncelemeBekliyor)).OrderByDescending(x=> x.Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _rezervasyonService.GetPI<RezervasyonDtoQ>(x=> x.Id == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(MuhasebeCalculate))]
        public IActionResult MuhasebeCalculate()
        {
            var result =  _rezervasyonService.MuhasebeCalculate();
            return Ok(result);
 
        }
        
        [HttpGet(nameof(MuhasebeCalculateMonth))]
        public IActionResult MuhasebeCalculateMonth()
        {
            var result =  _rezervasyonService.MuhasebeCalculateMonth();
            return Ok(result);
 
        }
        
        [HttpGet(nameof(MuhasebeCalculateWeek))]
        public IActionResult MuhasebeCalculateWeek()
        {
            var result =  _rezervasyonService.MuhasebeCalculateWeek();
            return Ok(result);
 
        }
        
        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonCustomerDtoQ>(x=> x.IsDeleted == false  && (x.RezervasyonDurum == RezervasyonDurum.Onayli || x.RezervasyonDurum == RezervasyonDurum.Opsiyon  ));
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetAllEntry))]
        public IActionResult GetAllEntry()
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonEntryDtoQ>(x=> x.IsDeleted == false && x.Active   && (x.RezervasyonDurum == RezervasyonDurum.Onayli || x.RezervasyonDurum == RezervasyonDurum.Opsiyon  )).OrderBy(x=>x.Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetAllEntrywithDate))]
        public IActionResult GetAllEntrywithDate(DateOnly dt)
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonEntryDtoQ>(x=> x.IsDeleted == false   && (x.RezervasyonDurum == RezervasyonDurum.Onayli || x.RezervasyonDurum == RezervasyonDurum.Opsiyon  ) &&
                                                                                                                           x.StartDate == dt && x.Active);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpPost(nameof(Add))]
        public  ActionResult<ResponseModel> Add(RezervasyonDtoC dto)
        { 
            
            return new ResponseModel(_rezervasyonService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(RezervasyonDtoC dto)
        {
            return new ResponseModel( _rezervasyonService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            
            return new ResponseModel( _rezervasyonService.DeleteRezervation(Id));
        }
    }
}