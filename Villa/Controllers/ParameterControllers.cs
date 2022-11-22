using Microsoft.AspNetCore.Mvc;
using Villa.Domain.Auth;
using Villa.Service.Contract;
using System.Threading.Tasks;
using Serilog;
using Villa.Service.Implementation;
using Villa.Domain.Dtos;
using Villa.Domain.Entities;
using Villa.Domain.Common;

namespace Villa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParameterControllers : ControllerBase
    {
        private readonly ParameterService _ParaBirimiService;

        public ParameterControllers(ParameterService parameterService)
        {
            _ParaBirimiService = parameterService;
        }

        [HttpGet(nameof(GetAll))]
        public IActionResult GetAll()
        {

            var result = _ParaBirimiService.GetAllParameter();
            if (result is not null)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpDelete(nameof(Delete))]
        public ResponseModel Delete(int id)
        {

            var result = _ParaBirimiService.DeleteParameter(id);
            return new ResponseModel(result);
        }

        [HttpPost(nameof(Add))]
        public IActionResult Add(Parameters parameter)
        {
            var result = _ParaBirimiService.AddParameter(parameter);
            if (result is not null)
            {
                return Ok(new ResponseModel(Message: "Başarıyla Eklendi", true));
            }
            return Ok(new ResponseModel(Message: "Eklenemedi", false));

        }

        [HttpPut(nameof(Update))]
        public ResponseModel Update(Parameters parameter)
        {
            var result = _ParaBirimiService.UpdateParameter(parameter);
            return new ResponseModel(result);

        }
    }
}