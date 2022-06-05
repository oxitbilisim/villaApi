using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Threading.Tasks;
using Villa.Domain.Common;
using Villa.Domain.Dtos;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Il")]
    public class IlController : ControllerBase
    {
        private readonly IIlService _ilService;

        public IlController(IIlService ilService)
        {
            _ilService = ilService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ilService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _ilService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(IlDtoC dto)
        { 
            return await _ilService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(IlDtoC dto)
        {
            return await _ilService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _ilService.Delete(Id);
        }
    }
}