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
    [Route("api/RezarvasyonEkstraHizmet")]
    public class RezarvasyonEkstraHizmetController : ControllerBase, IDisposable
    {
        private readonly RezervasyonEkstraHizmetService _rezarvasyonEkstraHizmetService;
        public RezarvasyonEkstraHizmetController(RezervasyonEkstraHizmetService rezarvasyonEkstraHizmetService)
        {
            _rezarvasyonEkstraHizmetService = rezarvasyonEkstraHizmetService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _rezarvasyonEkstraHizmetService.GetPI<RezervasyonEkstraHizmetQ>(x=> x.RezervasyonId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetEkstraHizmetRezervasyonById))]
        public ResponseModel GetEkstraHizmetRezervasyonById(int id)
        {
            var result =  _rezarvasyonEkstraHizmetService.GetPI<RezervasyonEkstraHizmetQ>(x=> x.RezervasyonId == id).OrderBy(x=> x.EkstraHizmetAd);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(RezervasyonEkstraHizmetC dto)
        { 
            return  new ResponseModel(_rezarvasyonEkstraHizmetService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(RezervasyonEkstraHizmetC dto)
        {
            return  new ResponseModel(_rezarvasyonEkstraHizmetService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_rezarvasyonEkstraHizmetService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}