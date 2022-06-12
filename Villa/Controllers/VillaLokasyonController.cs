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
    [Route("api/VillaLokasyon")]
    public class VillaLokasyonController : ControllerBase
    {
        private readonly IVillaLokasyonService _villaLokasyonService;

        public VillaLokasyonController(IVillaLokasyonService villaLokasyonService)
        {
            _villaLokasyonService = villaLokasyonService;
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _villaLokasyonService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(VillaLokasyonDtoC dto)
        { 
            return await _villaLokasyonService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(VillaLokasyonDtoC dto)
        {
            return await _villaLokasyonService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _villaLokasyonService.Delete(Id);
        }
    }
}