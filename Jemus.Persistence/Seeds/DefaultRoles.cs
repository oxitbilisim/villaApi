using Microsoft.AspNetCore.Identity;
using Jemus.Domain.Enum;
using System.Collections.Generic;

namespace Jemus.Persistence.Seeds
{

    public static class DefaultRoles
    {
        public static List<IdentityRole> IdentityRoleList()
        {
            return new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = Constants.SistemAdmin,
                    Name = Roles.SistemAdmin.ToString(),
                    NormalizedName = Roles.SistemAdmin.ToString()
                },
                new IdentityRole
                {
                    Id = Constants.IlAdmin,
                    Name = Roles.IlAdmin.ToString(),
                    NormalizedName = Roles.IlAdmin.ToString()
                },
                new IdentityRole
                {
                    Id = Constants.IlceAdmin,
                    Name = Roles.IlceAdmin.ToString(),
                    NormalizedName = Roles.IlceAdmin.ToString()
                },
                new IdentityRole
                {
                    Id = Constants.Karakol,
                    Name = Roles.Karakol.ToString(),
                    NormalizedName = Roles.Karakol.ToString()
                }
            };
        }
    }
}
