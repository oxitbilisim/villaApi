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
    [Route("api/VillaKategori")]
    public class VillaKategoriController : ControllerBase, IDisposable
    {
        private readonly VillaKategoriService _villaKategoriService;
        public VillaKategoriController(VillaKategoriService villaKategoriService)
        {
            _villaKategoriService = villaKategoriService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaKategoriService.GetPI<VillaKategoriDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetKategoriVillaById))]
        public ResponseModel GetKategoriVillaById(int id)
        {
            var result =  _villaKategoriService.GetPI<VillaKategoriDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaKategoriDtoC dto)
        { 
            return  new ResponseModel(_villaKategoriService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaKategoriDtoC dto)
        {
            return  new ResponseModel(_villaKategoriService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaKategoriService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}