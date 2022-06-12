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
    [Route("api/VillaImage")]
    public class VillaImageController : ControllerBase
    {
        private readonly IVillaImageService _villaImageService;

        public VillaImageController(IVillaImageService villaImageService)
        {
            _villaImageService = villaImageService;
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _villaImageService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return  NoContent();
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(VillaImageDtoC dto)
        { 
            return await _villaImageService.Add(dto);
        }
        [HttpPut(nameof(Update))]
        public async Task<ActionResult<ResponseModel>> Update(VillaImageDtoC dto)
        {
            return await _villaImageService.Update(dto);
        }
        [HttpDelete(nameof(Delete))]
        public async Task<ActionResult<ResponseModel>> Delete(int Id)
        {
            return await _villaImageService.Delete(Id);
        }
    }
}