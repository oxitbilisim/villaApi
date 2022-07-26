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
    [Route("api/BlogSeo")]
    public class BlogSeoController : ControllerBase, IDisposable
    {
        private readonly BlogSeoService _blogSeoService;
        public BlogSeoController(BlogSeoService blogSeoService)
        {
            _blogSeoService = blogSeoService;
        }
        
        [HttpGet(nameof(GetById))]
        public ResponseModel GetById(int id)
        {
            var result =  _blogSeoService.GetPI<BlogSeoDtoQ>(x=> x.BlogId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }
        
        [HttpGet(nameof(GetIcerikBlogById))]
        public ResponseModel GetIcerikBlogById(int id)
        {
            var result =  _blogSeoService.GetPI<BlogSeoDtoQ>(x=> x.BlogId == id);
            if (result is not null)
            {
                return new ResponseModel(result);
            }
            return new ResponseModel();
        }

        [HttpPost(nameof(Add))]
        public ResponseModel Add(BlogSeoDtoC dto)
        { 
            return  new ResponseModel(_blogSeoService.Add(dto));
        }
        
        [HttpPut(nameof(Update))]
        public ResponseModel Update(BlogSeoDtoC dto)
        {
            return  new ResponseModel(_blogSeoService.Update(dto)); ;
        }
        
        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int Id)
        {
            return  new ResponseModel(_blogSeoService.Delete(Id));
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}