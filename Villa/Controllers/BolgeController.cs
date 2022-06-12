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
    [Route("api/Bolge")]
    public class BolgeController : ControllerBase
    {
        private readonly IBolgeService _bolgeService;

        public BolgeController(IBolgeService bolgeService)
        {
            _bolgeService = bolgeService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _bolgeService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _bolgeService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(BolgeDtoC dto)
        { 
            return await _bolgeService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(BolgeDtoC dto)
        {
            return await _bolgeService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _bolgeService.Delete(Id);
        }
    }
}