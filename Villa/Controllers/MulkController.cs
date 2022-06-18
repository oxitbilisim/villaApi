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
    [Route("api/Mulk")]
    public class MulkController : ControllerBase
    {
        private readonly MulkService _mulkService;

        public MulkController(MulkService mulkService)
        {
            _mulkService = mulkService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _mulkService.GetAllPI<MulkDtoQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _mulkService.GetPI<MulkDtoQ>(x=> x.Id == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        [HttpPost(nameof(Add))]
        public ActionResult<ResponseModel> Add(MulkDtoC dto)
        { 
            return  new ResponseModel(_mulkService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ActionResult<ResponseModel> Update(MulkDtoC dto)
        {
            return  new ResponseModel(_mulkService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public  ActionResult<ResponseModel> Delete(int Id)
        {
            return  new ResponseModel(_mulkService.Delete(Id));
        }
    }
}