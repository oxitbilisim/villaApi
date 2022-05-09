using Villa.Domain.Auth;
using Villa.Domain.Common;
using Villa.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Villa.Service.Contract
{
    public interface IRoleService
    {
        Task<Response<List<RoleDto>>> GetRoles();
        Task<Response<string>> RegisterRoleAsync(RoleRequest request);
        Task<Response<string>> RoleAssign(string id);
        Task<Response<List<RoleUsersDto>>> GetUserRoles();
 
    }
}
