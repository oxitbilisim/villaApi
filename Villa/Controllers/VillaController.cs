using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Linq;
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
            var result =  _villaService.GetAllPI<VillaDtoQ>(x=> x.IsDeleted == false).OrderByDescending(x=> x.Id);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        [HttpGet(nameof(GetAlls))]
        public IActionResult GetAlls()
        {
            var result = _villaService.villaGelAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetAllF))]
        public IActionResult GetAllF()
        {
            var result =  _villaService.GetAllPI<VillaDtoQ>(x=> x.IsDeleted == false).OrderBy(x=> x.Id);
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
            dto.Ad = dto.Ad.Trim();
            dto.Baslik = dto.Baslik.Trim();
            
            var result = _villaService.GetPI<VillaDtoQ>(x => x.Ad.ToLower() == dto.Ad.ToLower() || x.Url.ToLower() == dto.Url.ToLower()).FirstOrDefault();
           
            if (result is not null)
            {
                return new ResponseModel(Success:false,Message:"Villa İsmi Mevcut");
            }
            return new ResponseModel(_villaService.Add(dto));
           
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(VillaDtoC dto)
        {
            dto.Ad = dto.Ad.Trim();
            dto.Baslik = dto.Baslik.Trim();
            return new ResponseModel( _villaService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            return new ResponseModel( _villaService.Delete(Id));
        }
        [HttpDelete(nameof(Pasif))]
        public ActionResult<ResponseModel> Pasif(int Id)
        {
            return new ResponseModel(_villaService.Pasif(Id));
        }
        [HttpDelete(nameof(Active))]
        public ActionResult<ResponseModel> Active(int Id)
        {
            return new ResponseModel(_villaService.Active(Id));
        }
    }
}