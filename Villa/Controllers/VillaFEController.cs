using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
            var result = _villaFEService.GetBolgeFE(rules);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        
        [HttpGet(nameof(GetKategoriAll))]
        public IActionResult GetKategoriAll(int rules)
        {
            var result = _villaFEService.GetKategoriFE(rules);
         
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }
    }
}