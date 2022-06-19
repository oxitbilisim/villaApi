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
    [Route("api/VillaLokasyon")]
    public class VillaLokasyonController : ControllerBase
    {
        private readonly VillaLokasyonService _villaLokasyonService;

        public VillaLokasyonController(VillaLokasyonService villaLokasyonService)
        {
            _villaLokasyonService = villaLokasyonService;
        }
        

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaLokasyonService.GetPI<VillaLokasyonDtoQ>(x=> x.Id == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpGet(nameof(GetLokasyonVillaById))]
        public ResponseModel GetLokasyonVillaById(int id)
        {
            var result =  _villaLokasyonService.GetPI<VillaLokasyonDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        [HttpPost(nameof(Add))]
        public ActionResult<ResponseModel> Add(VillaLokasyonDtoC dto)
        { 
            return  new ResponseModel(_villaLokasyonService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(VillaLokasyonDtoC dto)
        {
            return  new ResponseModel(_villaLokasyonService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            return  new ResponseModel(_villaLokasyonService.Delete(Id));
        }
    }
}