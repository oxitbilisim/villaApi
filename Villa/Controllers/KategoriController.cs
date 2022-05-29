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
    [Route("api/Kategori")]
    public class KategoriController : ControllerBase
    {
        private readonly IKategoriService _kategoriService;

        public KategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _kategoriService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _kategoriService.Get(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(KategoriDtoC kategori)
        { 
            return await _kategoriService.Add(kategori);
        }
        [HttpPut(nameof(Update))]
        public IActionResult Update(KategoriDtoC kategori)
        {
            _kategoriService.Update(kategori);
            return Ok("Updation done");
        }
        [HttpDelete(nameof(Delete))]
        public IActionResult Delete(int Id)
        {
            _kategoriService.Delete(Id);
            return Ok("Data Deleted");
        }
    }
}