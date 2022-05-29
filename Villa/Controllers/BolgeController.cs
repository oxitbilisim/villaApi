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
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetBolge))]
        public async Task<IActionResult> GetBolge(int id)
        {
            var result = await _bolgeService.GetBolge(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(Add))]
        public async Task<ActionResult<ResponseModel>> Add(BolgeDtoC bolge)
        { 
            return await _bolgeService.AddBolge(bolge);
        }
        [HttpPut(nameof(Update))]
        public IActionResult Update(BolgeDtoC bolge)
        {
            _bolgeService.UpdateBolge(bolge);
            return Ok("Updation done");
        }
        [HttpDelete(nameof(Delete))]
        public IActionResult Delete(int Id)
        {
            _bolgeService.DeleteBolge(Id);
            return Ok("Data Deleted");
        }
    }
}