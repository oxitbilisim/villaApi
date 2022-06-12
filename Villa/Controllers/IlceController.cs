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
    [Route("api/Ilce")]
    public class IlceController : ControllerBase
    {
        private readonly IIlceService _ilceService;

        public IlceController(IIlceService ilceService)
        {
            _ilceService = ilceService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ilceService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return  NoContent();
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _ilceService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return  NoContent();
        }
        
        [HttpGet(nameof(GetAllAsyncIlId))]
        public async Task<IActionResult> GetAllAsyncIlId(int id)
        {
            var result = await _ilceService.GetAllAsyncIlId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return  NoContent();
        }
        

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(IlceDtoC dto)
        { 
            return await _ilceService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(IlceDtoC dto)
        {
            return await _ilceService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _ilceService.Delete(Id);
        }
    }
}