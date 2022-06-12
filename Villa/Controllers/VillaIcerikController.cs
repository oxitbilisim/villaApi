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
    [Route("api/VillaIcerik")]
    public class VillaIcerikController : ControllerBase
    {
        private readonly IVillaIcerikService _villaIcerikService;

        public VillaIcerikController(IVillaIcerikService villaIcerikService)
        {
            _villaIcerikService = villaIcerikService;
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _villaIcerikService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return  NoContent();
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(VillaIcerikDtoC dto)
        { 
            return await _villaIcerikService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(VillaIcerikDtoC dto)
        {
            return await _villaIcerikService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _villaIcerikService.Delete(Id);
        }
    }
}