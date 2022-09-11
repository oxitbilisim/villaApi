using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Contract;
using Villa.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using Villa.Domain.Enum;
using Villa.Persistence;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Dashboard")]
    public class DashboardController : ControllerBase, IDisposable
    {
        private readonly IAppDbContext _appDbContext;

        public DashboardController(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet(nameof(Toplam))]
        public IActionResult Toplam()
        {
            var villaToplam = _appDbContext.Villa.Where(x => x.Active).Count();
            var bolgeToplam = _appDbContext.Bolge.Where(x => x.Active).Count();
            var kategoriToplam = _appDbContext.Kategori.Where(x => x.Active).Count();
            var rezervasyonToplam = _appDbContext.Rezervasyon.Where(x => x.Active && x.RezervasyonDurum == RezervasyonDurum.Onayli && x.CreateDate == DateTime.Today).Count();

            var dashboardDto = new DashboardToplams();
            dashboardDto.bolgeToplam = bolgeToplam;
            dashboardDto.villaToplam = villaToplam;
            dashboardDto.kategoriToplam = kategoriToplam;
            dashboardDto.rezervasyonGunlukToplam = rezervasyonToplam;

            if (dashboardDto is not null)
            {
                return Ok(dashboardDto);
            }
            return Ok(dashboardDto);
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}