using Microsoft.AspNetCore.Mvc;
using Villa.Domain.Auth;
using Villa.Service.Contract;
using System.Threading.Tasks;
using Serilog;

namespace Villa.Controllers
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

        [HttpGet("getRoles")]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await _roleService.GetRoles());
        }

        [HttpPost("rolRegister")]
        public async Task<IActionResult> RegisterRoleAsync(RoleRequest request)
        {

            return Ok(await _roleService.RegisterRoleAsync(request));
        }

        [HttpPost("userRoleAssign")]
        public async Task<IActionResult> RoleAssign(string id)
        {
            return Ok(await _roleService.RoleAssign(id));
        }

        [HttpGet("roleWithUser")]
        public async Task<IActionResult> GetUserRoles()
        {
            return Ok(await _roleService.GetUserRoles());
        }
    }
}