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
    [Route("api/VillaPeriyodikFiyat")]
    public class VillaPeriyodikFiyatController : ControllerBase
    {
        private readonly IVillaPeriyodikFiyatService _villaPeriyodikFiyatService;

        public VillaPeriyodikFiyatController(IVillaPeriyodikFiyatService villaPeriyodikFiyatService)
        {
            _villaPeriyodikFiyatService = villaPeriyodikFiyatService;
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _villaPeriyodikFiyatService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(VillaPeriyodikFiyatDtoC dto)
        { 
            return await _villaPeriyodikFiyatService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(VillaPeriyodikFiyatDtoC dto)
        {
            return await _villaPeriyodikFiyatService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _villaPeriyodikFiyatService.Delete(Id);
        }
    }
}