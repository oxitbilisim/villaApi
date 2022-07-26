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
    [Route("api/BlogKategori")]
    public class BlogKategoriController : ControllerBase, IDisposable
    {
        private readonly BlogKategoriService _blogKategoriService;

        public BlogKategoriController(BlogKategoriService blogKategoriService)
        {
            _blogKategoriService = blogKategoriService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {
            var result =  _blogKategoriService.GetAllPI<BlogKategoriDtoQ>(x=> x.IsDeleted == false);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
       

        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _blogKategoriService.GetPI<BlogKategoriDtoQ>(x=> x.Id == id
                                                                           );
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(BlogKategoriDtoC dto)
        { 
            return new ResponseModel(_blogKategoriService.Add(dto));
        }
        [HttpPut(nameof(Update))]
        public ResponseModel Update(BlogKategoriDtoC dto)
        {
            return  new ResponseModel(_blogKategoriService.Update(dto)); ;
        }
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_blogKategoriService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}