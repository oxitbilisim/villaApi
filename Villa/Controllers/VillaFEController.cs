using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Utilities;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/VillaFE")]
    public class VillaFEController : ControllerBase
    {
        private readonly VillaFEService _villaFEService;


        public VillaFEController(
            VillaFEService villaFEService
        )
        {
            _villaFEService = villaFEService;
        }

        [HttpGet(nameof(GetBolgeAll))]
        public IActionResult GetBolgeAll(int rules)
        {
            var result = _villaFEService.GetBolge(rules);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetBolgeVillas))]
        public IActionResult GetBolgeVillas(int bolgeId)
        {
            var result = _villaFEService.GetBolgeVillas(bolgeId);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        
        [HttpGet(nameof(GetKategoriAll))]
        public IActionResult GetKategoriAll(int rules)
        {
            var result = _villaFEService.GetKategori(rules);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetKategoriVillas))]
        public IActionResult GetKategoriVillas(int kategoriId)
        {
            var result = _villaFEService.GetKategoriVillas(kategoriId);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetVillaByURL))]
        public IActionResult GetVillaByURL(string url)
        {
            var result = _villaFEService.GetVillaByUrl(url);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        
        [HttpGet(nameof(GetPopularVillas))]
        public IActionResult GetPopularVillas(int limit)
        {
            var result = _villaFEService.GetPopularVillas(limit);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetRegionImage))]
        public async Task<FileContentResult> GetRegionImage(int id)
        {
            
            byte[] content = _villaFEService.GetRegionImage(id);
            Response.Headers.Add("Content-Disposition", "inline; filename=villalarim-"+id);
            return new FileContentResult(content, "image/png");
        }
        
        [HttpGet(nameof(GetVillaImage))]
        public async Task<FileContentResult> GetVillaImage(int id)
        {
            
            byte[] content = _villaFEService.GetVillaImage(id);
            Response.Headers.Add("Content-Disposition", "inline; filename=villalarim-"+id);
            return new FileContentResult(content, "image/png");
        }
        [HttpGet("villa-image/{id}.jpg")]
        public async Task<FileContentResult> GetVillaImagejpg(int id)
        {
            
            byte[] content = _villaFEService.GetVillaImage(id);
            Response.Headers.Add("Content-Disposition", "inline; filename=villalarim-"+id);
            return new FileContentResult(content, "image/png");
        }
        
        [HttpGet(nameof(GetProperties))]
        public IActionResult GetProperties()
        {
            var result = _villaFEService.GetAllProperty();
            return Ok(result);
        }
        
        [HttpGet(nameof(GetEstates))]
        public IActionResult GetEstates()
        {
            var result = _villaFEService.GetAllEstates();
            return Ok(result);
        }
        
        
        [HttpGet(nameof(SearchVilla))]
        public IActionResult SearchVilla(string region,
            string category,
            string type,
            string property,
            string startprice,
            string endprice,
            string name,
            string startPrice,
            string endPrice,
            string guestCount
            )
        {
            List<int> filterRegion = new List<int>();
            List<int> filterCategory = new List<int>();
            List<int> filterType = new List<int>();
            List<int> filterProperty = new List<int>();
            string filterName = null;
            double filterStartPrice = -1;
            double filterEndPrice = -1;
            int filterGuestCount = 0;

            if (!String.IsNullOrEmpty(region))
            {
                filterRegion = region.Replace(" ", "").Split(',').Select(Int32.Parse).ToList();
            }
            if (!String.IsNullOrEmpty(category))
            {
                filterCategory = category.Replace(" ", "").Split(',').Select(Int32.Parse).ToList();
            }
            if (!String.IsNullOrEmpty(property))
            {
                filterProperty = property.Replace(" ", "").Split(',').Select(Int32.Parse).ToList();
            }
            if (!String.IsNullOrEmpty(type))
            {
                filterType = type?.Replace(" ", "").Split(',').Select(Int32.Parse).ToList();
            }
            if (!String.IsNullOrEmpty(name))
            {
                filterName = WebUtility.UrlDecode(name);
            }
            if (!String.IsNullOrEmpty(startprice))
            {
                filterStartPrice = Double.Parse(WebUtility.UrlDecode(startprice));
            }
            if (!String.IsNullOrEmpty(endprice))
            {
                filterEndPrice = Double.Parse(WebUtility.UrlDecode(endprice));
            }
            if (!String.IsNullOrEmpty(guestCount))
            {
                filterGuestCount = Int16.Parse(WebUtility.UrlDecode(guestCount));
            }
            
            
            var result = _villaFEService.SearchVillas(
                filterRegion,
                filterCategory,
                filterType,
                filterProperty,
                filterName,
                filterStartPrice,
                filterEndPrice,
                filterGuestCount);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        
        [HttpPost(nameof(GetVillaByIds))]
        public IActionResult GetVillaByIds(VillaIdsFQ rb)
        {
            var result = _villaFEService.GetVillasByIds(rb);
            return Ok(result);
        }
        
        [HttpPost(nameof(CreateCollection))]
        public IActionResult CreateCollection(CollectionVillaFQ rb)
        {
            if (rb.Ids.Count==0)
            {
                return BadRequest();
            }
            var result = _villaFEService.CreateCollection(rb);
            return Ok(result.Result.UserData);
        }
        [HttpGet(nameof(GetCollectionVillas))]
        public IActionResult GetCollectionVillas(Guid key)
        {
            var result = _villaFEService.GetCollectionVillas(key);
            return Ok(result);
        }
        
        [HttpGet(nameof(GetAllBlogs))]
        public IActionResult GetAllBlogs()
        {
            var list = _villaFEService.GetAllBlogs();
            return Ok(list);
        }
        [HttpGet(nameof(GetBlogByURL))]
        public IActionResult GetBlogByURL(string url)
        {
            var blog = _villaFEService.GetBlogByURL(url);
            return Ok(blog);
        }
        
        [HttpGet(nameof(GetBlogImage))]
        public async Task<FileContentResult> GetBlogImage(int id)
        {
            
            byte[] content = _villaFEService.GetBlogImage(id);
            Response.Headers.Add("Content-Disposition", "inline; filename=villalarim-blog-"+id);
            return new FileContentResult(content, "image/png");
        }
    }
}