using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Villa")]
    public class VillaController : ControllerBase
    {
        private readonly VillaService _villaService;

        public VillaController(VillaService villaService)
        {
            _villaService = villaService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _villaService.GetAllPI<VillaDtoQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaService.GetPI<VillaDtoQ>(x=> x.Id == id,
                x=> x.Include(y=> y.Mulk));
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public  ActionResult<ResponseModel> Add(VillaDtoC dto)
        { 
            return new ResponseModel(_villaService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(VillaDtoC dto)
        {
            return new ResponseModel( _villaService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            return new ResponseModel( _villaService.Delete(Id));
        }
    }
}