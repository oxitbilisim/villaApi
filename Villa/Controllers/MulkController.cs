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
    [Route("api/Mulk")]
    public class MulkController : ControllerBase
    {
        private readonly IMulkService _mulkService;

        public MulkController(IMulkService mulkService)
        {
            _mulkService = mulkService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mulkService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return  NoContent();
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mulkService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return  NoContent();
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(MulkDtoC dto)
        { 
            return await _mulkService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(MulkDtoC dto)
        {
            return await _mulkService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _mulkService.Delete(Id);
        }
    }
}