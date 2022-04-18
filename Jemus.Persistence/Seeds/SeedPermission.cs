
using Jemus.Domain.Utilities;
using Jemus.Entities.Models;
using System;
using System.Collections.Generic;

namespace Jemus.Persistence.Seeds
{
    public static class SeedPermission
    {
        public static List<Permission> PermissionList()
        {

            List<Permission> pL = new List<Permission>();

            for (int i = 1; i <= Permissions.getPermissions().Count; i++)
            {
                pL.Add(new Permission()
                {
                    Id = Guid.NewGuid(),
                    Name = Permissions.getPermissions()[i - 1]
                });

            }
            return pL;
        }
    }
}
