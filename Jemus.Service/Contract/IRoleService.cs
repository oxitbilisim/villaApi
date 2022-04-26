using Jemus.Domain.Auth;
using Jemus.Domain.Common;
using Jemus.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jemus.Service.Contract
{
    public interface IRoleService
    {
        Task<Response<string>> RegisterRoleAsync(RoleRequest request);
        Task<Response<string>> RoleAssign(string id);
        Task<Response<List<RoleDto>>> GetRol();
    }
}
