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
    [Route("api/EkstraHizmet")]
    public class EkstraHizmetController : ControllerBase, IDisposable
    {
        private readonly EkstraHizmetService _EkstraHizmetService;

        public EkstraHizmetController(EkstraHizmetService EkstraHizmetService)
        {
            _EkstraHizmetService = EkstraHizmetService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _EkstraHizmetService.GetAllPI<EkstraHizmetDtoQ>(x=> x.IsDeleted == false).OrderBy(x=>x.Ad);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _EkstraHizmetService.GetPI<EkstraHizmetDtoQ>(x=> x.Id == id
                                                                           );
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(EkstraHizmetDtoC dto)
        { 
            return new ResponseModel(_EkstraHizmetService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ResponseModel Update(EkstraHizmetDtoC dto)
        {
            return  new ResponseModel(_EkstraHizmetService.Update(dto)); ;
        }
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_EkstraHizmetService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}