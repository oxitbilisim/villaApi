﻿using MediatR;
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
    [Route("api/Rezervasyon")]
    public class RezervasyonController : ControllerBase
    {
        private readonly RezervasyonService _rezervasyonService;

        public RezervasyonController(RezervasyonService rezervasyonService)
        {
            _rezervasyonService = rezervasyonService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonDtoQ>(x=> x.IsDeleted == false);
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
        
        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonCustomerDtoQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetAllEntry))]
        public IActionResult GetAllEntry()
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonEntryDtoQ>(x=> x.IsDeleted == false && x.Active);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetAllEntrywithDate))]
        public IActionResult GetAllEntrywithDate(DateTimeOffset dt)
        {
            var result =  _rezervasyonService.GetAllPI<RezervasyonEntryDtoQ>(x=> x.IsDeleted == false &&   
                                                                                                                           x.Baslangic.Date == dt.Date && x.Active);
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
            return new ResponseModel( _rezervasyonService.Delete(Id));
        }
    }
}