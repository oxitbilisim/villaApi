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
    [Route("api/Bolge")]
    public class BolgeController : ControllerBase, IDisposable
    {
        private readonly BolgeService _bolgeService;

        public BolgeController(BolgeService bolgeService)
        {
            _bolgeService = bolgeService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _bolgeService.GetAllPI<BolgeDtoQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
       

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _bolgeService.GetPI<BolgeDtoQ>(x=> x.Id == id
                                                                           );
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(BolgeDtoC dto)
        { 
            return new ResponseModel(_bolgeService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ResponseModel Update(BolgeDtoC dto)
        {
            return  new ResponseModel(_bolgeService.Update(dto)); ;
        }
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_bolgeService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}