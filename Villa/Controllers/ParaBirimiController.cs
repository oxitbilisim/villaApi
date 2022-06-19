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
    [Route("api/ParaBirimi")]
    public class ParaBirimiController : ControllerBase, IDisposable
    {
        private readonly ParaBirimiService _ParaBirimiService;

        public ParaBirimiController(ParaBirimiService ParaBirimiService)
        {
            _ParaBirimiService = ParaBirimiService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _ParaBirimiService.GetAllPI<ParaBirimiDtoQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _ParaBirimiService.GetPI<ParaBirimiDtoQ>(x=> x.Id == id
                                                                           );
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(ParaBirimiDtoC dto)
        { 
            return new ResponseModel(_ParaBirimiService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ResponseModel Update(ParaBirimiDtoC dto)
        {
            return  new ResponseModel(_ParaBirimiService.Update(dto)); ;
        }
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_ParaBirimiService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}