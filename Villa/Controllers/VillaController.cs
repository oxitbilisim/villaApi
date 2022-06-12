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
    [Route("api/Villa")]
    public class VillaController : ControllerBase
    {
        private readonly IVillaService _villaService;

        public VillaController(IVillaService villaService)
        {
            _villaService = villaService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _villaService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _villaService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(VillaDtoC dto)
        { 
            return await _villaService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(VillaDtoC dto)
        {
            return await _villaService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _villaService.Delete(Id);
        }
    }
}