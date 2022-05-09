using Microsoft.AspNetCore.Identity;
using Villa.Domain.Enum;
using System.Collections.Generic;

namespace Villa.Persistence.Seeds
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
                    Name = Roles.SISTEMADMIN.ToString().ToLower(),
                    NormalizedName = Roles.SISTEMADMIN.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Id = Constants.IlAdmin,
                    Name = Roles.ILADMIN.ToString().ToLower(),
                    NormalizedName = Roles.ILADMIN.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Id = Constants.IlceAdmin,
                    Name = Roles.ILCEADMIN.ToString().ToLower(),
                    NormalizedName = Roles.ILCEADMIN.ToString().ToUpper()
                },
                new IdentityRole
                {
                    Id = Constants.Karakol,
                    Name = Roles.KARAKOL.ToString().ToLower(),
                    NormalizedName = Roles.KARAKOL.ToString().ToUpper()
                }
            };
        }
    }
}
