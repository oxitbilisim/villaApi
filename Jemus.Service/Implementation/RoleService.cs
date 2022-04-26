using Microsoft.AspNetCore.Identity;
using Jemus.Domain.Auth;
using Jemus.Domain.Common;
using Jemus.Service.Contract;
using Jemus.Service.Exceptions;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.Logging;
using Jemus.Persistence;
using Jemus.Entities.Models;
using System.Collections.Generic;
using Jemus.Domain.Dtos;
using Jemus.Domain.Entities;

namespace Jemus.Service.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        private IAppDbContext _appDbContext;
        private readonly ILogger<RoleService> _logger;

        public RoleService(UserManager<User> userManager, 
                           RoleManager<IdentityRole> roleManager,
                           IAppDbContext appDbContext,
                           ILogger<RoleService> logger
                           )
        {
            _roleManager = roleManager;
            _userManager = userManager;
            this._appDbContext = appDbContext;
            _logger = logger;
        }

        public async Task<Response<string>> RegisterRoleAsync(RoleRequest request)
        {
            var roleName = await _roleManager.FindByNameAsync(request.Name);
            if (roleName != null)
            {
                throw new ApiException($"Username '{request.Name}' is already taken.");
            }
            var role = new IdentityRole
            {
                Name = request.Name,
                NormalizedName = request.Name
            };
          
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                var permissionroles = _appDbContext.Permission.ToList();
                foreach (var item in permissionroles)
                {
                    _appDbContext.RoleClaims.Add(new IdentityRoleClaim<string>
                    {
                        RoleId = role.Id,
                        ClaimValue = item.Name,
                        ClaimType = "permission"
                    });
                }

                 var permissionGuid = _appDbContext.Permission.FirstOrDefault(x => x.Name == "Permissions.Genel.All").Id;
                    var menus = _appDbContext.Menu.ToList();
                    foreach (var item in menus)
                    {
                        _appDbContext.MenuPermission.Add(new MenuPermission
                        {
                            RoleId = role.Id,
                            MenuId = item.Id,
                            PermissionId = permissionGuid
                        });
                    }
                    await _appDbContext.SaveChangesAsync();
              
                return new Response<string>(role.Id, message: $"Role Registered.");
            }
            else
            {
                throw new ApiException($"{result.Errors.ToList()[0].Description}");
            }
        }

        public async Task<Response<List<RoleDto>>> GetRol()
        {
            var dtoList = new List<RoleDto>();
           
            var roles = _roleManager.Roles.ToList();

            foreach (var item in roles)
            {
                var rolesUserList  = await _userManager.GetUsersInRoleAsync(item.NormalizedName);
                var userList = new List<UserDto>();
                foreach (var itemuser in rolesUserList)
                {  
                    userList.Add(new UserDto() { size = "sm", title =  $"{itemuser.Ad.ToUpper()} {itemuser.Soyad.ToUpper()}" .ToUpper() , img = itemuser.Image });
                }
                dtoList.Add( new RoleDto { title = item.NormalizedName.ToUpper() ,totalUsers = rolesUserList.Count, users = userList } );
            }
            return new Response<List<RoleDto>>(dtoList , message: $"User && Role Assiged.");
        }

        public async Task<Response<string>> RoleAssign(string id)
        {
            User user = await _userManager.FindByIdAsync(id);


            if (!await _userManager.IsInRoleAsync(user, "KARAKOL"))
            {
                _logger.LogInformation("Adding sysadmin to Admin role");
                var userResult = await _userManager.AddToRoleAsync(user, "KARAKOL");
            }

            await _userManager.AddToRoleAsync(user, "KARAKOL");

            return new Response<string>(user.Id, message: $"User && Role Assiged.");
        }
    }
}
