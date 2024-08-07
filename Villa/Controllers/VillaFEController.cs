﻿
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Villa.Domain.Dtos;
using Villa.Domain.Dtos.VillaFE;
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
        public IActionResult GetBolgeVillas(int bolgeId, string pn, string prc)
        {
            int pageNumber = pn != null && !pn.Trim().Equals("") ? Int32.Parse(pn) : 1;
            int pageRowCount = prc != null && !prc.Trim().Equals("") ? Int32.Parse(prc) : 20;

            var result = _villaFEService.GetBolgeVillas(bolgeId,
                pageNumber,
                pageRowCount);

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
        public IActionResult GetKategoriVillas(int kategoriId, string pn, string prc)
        {
            int pageNumber = pn != null && !pn.Trim().Equals("") ? Int32.Parse(pn) : 1;
            int pageRowCount = prc != null && !prc.Trim().Equals("") ? Int32.Parse(prc) : 20;

            var result = _villaFEService.GetKategoriVillas(kategoriId,
                pageNumber,
                pageRowCount);

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

            return NotFound(result);
        }

        [HttpGet(nameof(GetPageByURL))]
        public IActionResult GetPageByURL(string url)
        {
            var result = _villaFEService.GetPageByURL(url);

            if (result is not null)
            {
                return Ok(result);
            }

            return Ok(result);
        }

        [HttpGet(nameof(GetAllPages))]
        public IActionResult GetAllPages(string url)
        {
            var result = _villaFEService.GetAllPages();

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
            Response.Headers.Add("Content-Disposition", "inline; filename=villalarim-" + id);
            return new FileContentResult(content, "image/png");
        }

        [HttpGet(nameof(GetVillaImage))]
        public async Task<FileContentResult> GetVillaImage(int id)
        {
            byte[] content = _villaFEService.GetVillaImage(id);
            Response.Headers.Add("Content-Disposition", "inline; filename=villalarim-" + id);
            return new FileContentResult(content, "image/png");
        }

        [HttpGet("villa-image/{id}.jpg")]
        public async Task<FileContentResult> GetVillaImagejpg(int id)
        {
            byte[] content = _villaFEService.GetVillaImage(id);
            Response.Headers.Add("Content-Disposition", "inline; filename=villalarim-" + id);
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
        public IActionResult SearchVilla(string r, // region
            string c, // category
            string t,// type
            string p,// property
            string sp,// startprice
            string ep,// endprice
            string n,// name
            string sd,// startDate
            string ed,// endDate
            string gc,// guestCount
            string pn,
            string prc
        )
        {
            List<int> filterRegion = new List<int>();
            List<int> filterCategory = new List<int>();
            List<int> filterType = new List<int>();
            List<int> filterProperty = new List<int>();
            string filterName = null;
            decimal filterStartPrice = -1;
            decimal filterEndPrice = -1;
            DateOnly filterStartDate = DateOnly.MinValue;
            DateOnly filterEndDate = DateOnly.MaxValue;
            int filterGuestCount = 0;

            int pageNumber = pn != null && !pn.Trim().Equals("") ? Int32.Parse(pn) : 1;
            int pageRowCount = prc != null && !prc.Trim().Equals("") ? Int32.Parse(prc) : 20;

            if (!String.IsNullOrEmpty(r))
            {
                filterRegion = r.Replace(" ", "").Split(',').Select(Int32.Parse).ToList();
            }

            if (!String.IsNullOrEmpty(c))
            {
                filterCategory = c.Replace(" ", "").Split(',').Select(Int32.Parse).ToList();
            }

            if (!String.IsNullOrEmpty(p))
            {
                filterProperty = p.Replace(" ", "").Split(',').Select(Int32.Parse).ToList();
            }

            if (!String.IsNullOrEmpty(t))
            {
                filterType = t?.Replace(" ", "").Split(',').Select(Int32.Parse).ToList();
            }

            if (!String.IsNullOrEmpty(n))
            {
                filterName = WebUtility.UrlDecode(n);
            }

            if (!String.IsNullOrEmpty(sp))
            {
                filterStartPrice = Decimal.Parse(WebUtility.UrlDecode(sp));
            }

            if (!String.IsNullOrEmpty(ep))
            {
                filterEndPrice = Decimal.Parse(WebUtility.UrlDecode(ep));
            }

            if (!String.IsNullOrEmpty(sd))
            {
                filterStartDate = DateOnly.Parse(sd);
            }

            if (!String.IsNullOrEmpty(ed))
            {
                filterEndDate = DateOnly.Parse(ed);
            }

            if (!String.IsNullOrEmpty(gc))
            {
                filterGuestCount = Int16.Parse(WebUtility.UrlDecode(gc));
            }


            var result = _villaFEService.SearchVillas(
                filterRegion,
                filterCategory,
                filterType,
                filterProperty,
                filterName,
                filterStartPrice,
                filterEndPrice,
                filterStartDate,
                filterEndDate,
                filterGuestCount,
                pageNumber,
                pageRowCount
            );

            if (result is not null)
            {
                return Ok(result);
            }

            return Ok(result);
        }


        [HttpPost(nameof(GetVillaByIds))]
        public IActionResult GetVillaByIds(List<VillaIdsFQ> rb)
        {
            var result = _villaFEService.GetVillasByIds(rb);
            return Ok(result);
        }

        [HttpPost(nameof(CreateCollection))]
        public IActionResult CreateCollection(List<VillaIdsFQ> rb)
        {
            if (rb.Count == 0)
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
            Response.Headers.Add("Content-Disposition", "inline; filename=villalarim-blog-" + id);
            return new FileContentResult(content, "image/png");
        }

        [HttpGet(nameof(GetVillaReservations))]
        public IActionResult GetVillaReservations(int id, int year)
        {
            var reservations = _villaFEService.GetVillaReservations(id, year);
            return Ok(reservations);
        }

        [HttpGet(nameof(CostCalculate))]
        public IActionResult CostCalculate(int id, string startDate, string endDate)
        {
            DateOnly filterStartDate = DateOnly.Parse(startDate);
            DateOnly filterEndDate = DateOnly.Parse(endDate);
            ReservationCalculation calc = null;
            try
            {
                calc = _villaFEService.CostCalculate(id, filterStartDate, filterEndDate);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok(calc);
        }

        [HttpGet(nameof(UpdateExchangeRates))]
        public IActionResult UpdateExchangeRates()
        {
            _villaFEService.UpdateExchangeRates();
            return Ok();
        }

        [HttpGet(nameof(GetAllExtraServices))]
        public IActionResult GetAllExtraServices()
        {
            var list = _villaFEService.GetAllExtraServices();
            return Ok(list);
        }

        [HttpPost(nameof(SaveReservation))]
        public IActionResult SaveReservation(ReservationSaveDto saveDto)
        {
            try
            {
                var result = _villaFEService.saveReservation(saveDto);
                return Ok(result.Id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetReservationInfo))]
        public IActionResult GetReservationInfo(int reservationNo)
        {
            try
            {
                return Ok(_villaFEService.GetReservationInfo(reservationNo));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet(nameof(GetParameters))]
        public IActionResult GetParameters()
        {
            try
            {
                return Ok(_villaFEService.GetFilteredParameters());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}