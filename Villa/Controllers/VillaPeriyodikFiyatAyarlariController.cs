using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Threading.Tasks;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/VillaPeriyodikFiyatAyarlari")]
    public class VillaPeriyodikFiyatAyarlariController : ControllerBase
    {
        private readonly VillaPeriyodikFiyatAyarlariService _villaPeriyodikFiyatAyarlariService;

        public VillaPeriyodikFiyatAyarlariController(VillaPeriyodikFiyatAyarlariService villaPeriyodikFiyatAyarlariService)
        {
            _villaPeriyodikFiyatAyarlariService = villaPeriyodikFiyatAyarlariService;
        }
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaPeriyodikFiyatAyarlariService.Get(id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ActionResult<ResponseModel> Add(VillaPeriyodikFiyatAyarlariDtoC dto)
        { 
            return  new ResponseModel(_villaPeriyodikFiyatAyarlariService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(VillaPeriyodikFiyatAyarlariDtoC dto)
        {
            return  new ResponseModel(_villaPeriyodikFiyatAyarlariService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public  ActionResult<ResponseModel> Delete(int Id)
        {
            return  new ResponseModel(_villaPeriyodikFiyatAyarlariService.Delete(Id));
        }
    }
}