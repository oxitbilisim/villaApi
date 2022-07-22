using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Villa.Service.Implementation;

namespace Villa.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/Takvim")]
    public class TakvimController : ControllerBase
    {
        private readonly TakvimService _takvimService;

        public TakvimController(TakvimService takvimService)
        {
            _takvimService = takvimService;
        }

        [HttpGet(nameof(GetVillaByIdCalendarData))]
        public IActionResult GetVillaByIdCalendarData(int villaId)
        {
            var result =  _takvimService.GetVillaByIdCalendarData(villaId);
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

       
    }
}