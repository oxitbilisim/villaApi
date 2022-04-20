using Microsoft.AspNetCore.Mvc;
using Jemus.Domain.Auth;
using Jemus.Service.Contract;
using System.Threading.Tasks;
using Serilog;

namespace Jemus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
       
     

        [HttpPost("rolregister")]
        public async Task<IActionResult> RegisterRoleAsync(RoleRequest request)
        {

            return Ok(await _roleService.RegisterRoleAsync(request));
        }

        [HttpPost("userroleassign")]
        public async Task<IActionResult> RoleAssign(string id)
        {
            return Ok(await _roleService.RoleAssign(id));
        }

    }
}