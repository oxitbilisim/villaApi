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
    [Route("api/VillaGorunum")]
    public class VillaGorunumController : ControllerBase, IDisposable
    {
        private readonly VillaGorunumService _villaGorunumService;
        private readonly VillaOzellikService _villaOzellikService;
        private readonly VillaKategoriService _villaKategoriService;
        private readonly VillaGosterimService _villaGosterimService;
        
        public VillaGorunumController(
            VillaGorunumService villaGorunumService,
            VillaOzellikService villaOzellikService,
            VillaKategoriService villaKategoriService,
            VillaGosterimService villaGosterimService
            )
        {
            _villaGorunumService = villaGorunumService;
            _villaOzellikService = villaOzellikService;
            _villaKategoriService = villaKategoriService;
            _villaGosterimService = villaGosterimService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _villaGorunumService.GetPI<VillaGorunumDtoQ>(x=> x.VillaId == id)
                ;
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetGorunumVillaById))]
        public ResponseModel GetGorunumVillaById(int id)
        {
            var result =  _villaGorunumService.GetPI<VillaGorunumDtoQ>(x=> x.VillaId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(VillaGorunumDtoC dto)
        {
            _villaGorunumService.Add(dto);
            
            foreach (var item in dto.VillaOzellik)
            {
                item.VillaId = dto.VillaId;
                _villaOzellikService.Add(item);
            }
            
            foreach (var item1 in dto.VillaKategori)
            {
                item1.VillaId = dto.VillaId;
                _villaKategoriService.Add(item1);
            }
            
            foreach (var item2 in dto.VillaGosterim)
            {
                item2.VillaId = dto.VillaId;
                _villaGosterimService.Add(item2);
            }
            
            return  new ResponseModel();
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaGorunumDtoC dto)
        {
            _villaGorunumService.Update(dto);
            
            _villaOzellikService.DeleteHard((int)dto.VillaId);
            _villaKategoriService.DeleteHard((int)dto.VillaId);
            _villaGosterimService.DeleteHard((int)dto.VillaId);
            
            foreach (var item in dto.VillaOzellik)
            {
                item.VillaId = dto.VillaId;
                _villaOzellikService.Add(item);
            }
            
            foreach (var item1 in dto.VillaKategori)
            {
                item1.VillaId = dto.VillaId;
                _villaKategoriService.Add(item1);
            }
            
            foreach (var item2 in dto.VillaGosterim)
            {
                item2.VillaId = dto.VillaId;
                _villaGosterimService.Add(item2);
            }
            
            
            
            return  new ResponseModel(); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_villaGorunumService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}