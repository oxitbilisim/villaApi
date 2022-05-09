using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Auth;
using System.Collections.Generic;
using Villa.Entities.Models;
using Villa.Domain.Entities;

namespace Villa.Persistence.Seeds
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            CreateRoles(modelBuilder);

            CreateBasicUsers(modelBuilder);

            MapUserRole(modelBuilder);
            
            CreateMenu(modelBuilder);

            CreatePermissions(modelBuilder);
        }

        private static void CreateRoles(ModelBuilder modelBuilder)
        {
            List<IdentityRole> roles = DefaultRoles.IdentityRoleList();
            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }

        private static void CreateBasicUsers(ModelBuilder modelBuilder)
        {
            List<User> users = DefaultUser.IdentityBasicUserList();
            modelBuilder.Entity<User>().HasData(users);
        }

        private static void MapUserRole(ModelBuilder modelBuilder)
        {
            //var identityUserRoles = MappingUserRole.IdentityUserRoleList();
            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(identityUserRoles);
        }

        private static void CreateMenu(ModelBuilder modelBuilder)
        {

            var menu = SeedMenu.MenuList();
            modelBuilder.Entity<Menu>().HasData(menu);
        }

        private static void CreatePermissions(ModelBuilder modelBuilder)
        {
            var permission = SeedPermission.PermissionList();
            modelBuilder.Entity<Permission>().HasData(permission);
        }
    }
}
