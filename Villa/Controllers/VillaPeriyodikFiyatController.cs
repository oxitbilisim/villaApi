using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/VillaPeriyodikFiyat")]
    public class VillaPeriyodikFiyatController : ControllerBase
    {
        private readonly VillaPeriyodikFiyatService _villaPeriyodikFiyatService;

        public VillaPeriyodikFiyatController(VillaPeriyodikFiyatService villaPeriyodikFiyatService)
        {
            _villaPeriyodikFiyatService = villaPeriyodikFiyatService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaPeriyodikFiyatService.Get(id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetPFAVillaById))]
        public ResponseModel GetPFAVillaById(int id)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);   
            var result =  _villaPeriyodikFiyatService.GetPI<VillaPeriyodikFiyatDtoQ>(x=> x.VillaId == id  && x.IsDeleted == false && (x.StartDate>= today || today <= x.EndDate)).OrderBy(x=> x.StartDate);       
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ActionResult<ResponseModel> Add(VillaPeriyodikFiyatDtoC dto)
        { 
            return  new ResponseModel(_villaPeriyodikFiyatService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(VillaPeriyodikFiyatDtoC dto)
        {

            return new ResponseModel(_villaPeriyodikFiyatService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            return  new ResponseModel(_villaPeriyodikFiyatService.Delete(Id));
        }
    }
}