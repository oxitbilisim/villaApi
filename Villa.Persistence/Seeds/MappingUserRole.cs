using Microsoft.AspNetCore.Identity;
using Villa.Domain.Enum;
using System.Collections.Generic;

namespace Villa.Persistence.Seeds
{
    public static class MappingUserRole
    {
        public static List<IdentityUserRole<string>> IdentityUserRoleList()
        {
            return new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    RoleId = Constants.SistemAdmin,
                    UserId = Constants.SistemAdminUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = Constants.Admin,
                    UserId = Constants.VillaUser
                }
            };
        }
    }
}
