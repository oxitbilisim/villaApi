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
    [Route("api/Ilce")]
    public class IlceController : ControllerBase
    {
        private readonly IlceService _ilceService;

        public IlceController(IlceService ilceService)
        {
            _ilceService = ilceService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _ilceService.GetAllPI<BolgeDtoQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _ilceService.GetPI<IlceDtoQ>(x=> x.Id == id,
                x=> x.Include(y=> y.Il));
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetAllAsyncIlId))]
        public ResponseModel GetAllAsyncIlId(int id)
        {
            var result =  _ilceService.GetPI<IlceDtoQ>(x=> x.IlId == id,
                x=> x.Include(y=> y.Il));
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        

        [HttpPost(nameof(Add))]
        public  ActionResult<ResponseModel> Add(IlceDtoC dto)
        { 
            return  new ResponseModel(_ilceService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(IlceDtoC dto)
        {
            return  new ResponseModel(_ilceService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel> Delete(int Id)
        {
            return  new ResponseModel(_ilceService.Delete(Id));
        }
    }
}