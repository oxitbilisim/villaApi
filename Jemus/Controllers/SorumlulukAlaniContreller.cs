﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Jemus.Service.Contract;
using Jemus.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Jemus.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/SorumlulukAlani")]
    public class SorumlulukAlaniController : ControllerBase
    {
        private readonly ISorumlulukAlaniService _sorumlulukAlaniService;

        public SorumlulukAlaniController(ISorumlulukAlaniService sorumlulukAlaniService)
        {
            _sorumlulukAlaniService = sorumlulukAlaniService;
        }
        
        [HttpGet(nameof(GetAllAsync))]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _sorumlulukAlaniService.GetAllAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }

        [HttpGet(nameof(GetSorumlulukAlani))]
        public async Task<IActionResult> GetSorumlulukAlani(Guid id)
        {
            var result = await _sorumlulukAlaniService.GetSorumlulukAlaniAsync(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        
        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(SorumlulukAlani sorumlulukAlani)
        {
            _sorumlulukAlaniService.InsertCustomer(sorumlulukAlani);
            return Ok("Data inserted");

        }
        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(SorumlulukAlani sorumlulukAlani)
        {
            _sorumlulukAlaniService.UpdateCustomer(sorumlulukAlani);
            return Ok("Updation done");

        }
        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(Guid Id)
        {
            _sorumlulukAlaniService.DeleteCustomer(Id);
            return Ok("Data Deleted");

        }
    }
}
