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
            var result =  _villaGorunumService.GetPI<VillaGorunumDtoQ>(x=> x.VillaId == id);
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
            _villaOzellikService.Add(dto.VillaOzellik);
            _villaKategoriService.Add(dto.VillaKategori);
            _villaGosterimService.Add(dto.VillaGosterim);
            
            return  new ResponseModel();
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(VillaGorunumDtoC dto)
        {
            return  new ResponseModel(_villaGorunumService.Update(dto)); ;
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