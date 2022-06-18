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
    [Route("api/VillaIcerik")]
    public class VillaIcerikController : ControllerBase, IDisposable
    {
        private readonly VillaIcerikService _villaIcerikService;
        public VillaIcerikController(VillaIcerikService villaIcerikService)
        {
            _villaIcerikService = villaIcerikService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaIcerikService.Get(id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaIcerikDtoC dto)
        { 
            return  new ResponseModel(_villaIcerikService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaIcerikDtoC dto)
        {
            return  new ResponseModel(_villaIcerikService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaIcerikService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}