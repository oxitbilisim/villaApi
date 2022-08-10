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
    [Route("api/BlogIcerik")]
    public class BlogIcerikController : ControllerBase, IDisposable
    {
        private readonly BlogIcerikService _blogIcerikService;
        public BlogIcerikController(BlogIcerikService blogIcerikService)
        {
            _blogIcerikService = blogIcerikService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _blogIcerikService.GetPI<BlogIcerikDtoQ>(x=> x.BlogId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetIcerikBlogById))]
        public ResponseModel GetIcerikBlogById(int id)
        {
            var result =  _blogIcerikService.GetPI<BlogIcerikDtoQ>(x=> x.BlogId == id).OrderBy(x=>x.Id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(BlogIcerikDtoC dto)
        { 
            return  new ResponseModel(_blogIcerikService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(BlogIcerikDtoC dto)
        {
            return  new ResponseModel(_blogIcerikService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_blogIcerikService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}