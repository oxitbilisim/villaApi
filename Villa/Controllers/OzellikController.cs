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
    [Route("api/Ozellik")]
    public class OzellikController : ControllerBase, IDisposable
    {
        private readonly OzellikService _OzellikService;

        public OzellikController(OzellikService OzellikService)
        {
            _OzellikService = OzellikService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _OzellikService.GetAllPI<OzellikDtoQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _OzellikService.GetPI<OzellikDtoQ>(x=> x.Id == id
                                                                           );
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(OzellikDtoC dto)
        { 
            return new ResponseModel(_OzellikService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ResponseModel Update(OzellikDtoC dto)
        {
            return  new ResponseModel(_OzellikService.Update(dto)); ;
        }
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_OzellikService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}