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
    [Route("api/VillaPeriyodikFiyatAyarlari")]
    public class VillaPeriyodikFiyatAyarlariController : ControllerBase
    {
        private readonly IVillaPeriyodikFiyatAyarlariService _villaPeriyodikFiyatAyarlariService;

        public VillaPeriyodikFiyatAyarlariController(IVillaPeriyodikFiyatAyarlariService villaPeriyodikFiyatAyarlariService)
        {
            _villaPeriyodikFiyatAyarlariService = villaPeriyodikFiyatAyarlariService;
        }
        
        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _villaPeriyodikFiyatAyarlariService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(VillaPeriyodikFiyatAyarlariDtoC dto)
        { 
            return await _villaPeriyodikFiyatAyarlariService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(VillaPeriyodikFiyatAyarlariDtoC dto)
        {
            return await _villaPeriyodikFiyatAyarlariService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _villaPeriyodikFiyatAyarlariService.Delete(Id);
        }
    }
}