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
    [Route("api/Kategori")]
    public class KategoriController : ControllerBase, IDisposable
    {
        private readonly KategoriService _kategoriService;

        public KategoriController(KategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        [HttpGet(nameof(GetAll))]
        public  IActionResult GetAll()
        {
            var result = _kategoriService.GetAllPI<KategoriDtoQ>(x => x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(null);
        }
     
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result = _kategoriService.GetPI<KategoriDtoQ>(x => x.Id == id
                                                                   );
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(KategoriDtoC dto)
        { 
            return new ResponseModel(_kategoriService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ResponseModel  Update(KategoriDtoC dto)
        {
            return new ResponseModel(_kategoriService.Update(dto));
        }
        [HttpDelete(nameof(Delete))]
        public ActionResult<ResponseModel>  Delete(int Id)
        {
            return  new ResponseModel(_kategoriService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}