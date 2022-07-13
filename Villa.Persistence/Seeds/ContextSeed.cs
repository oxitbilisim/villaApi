using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Villa.Domain.Auth;
using System.Collections.Generic;
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
            
            CreateMulk(modelBuilder);

            CreateParaBirimi(modelBuilder);
            CreateIl(modelBuilder);

            CreateIlce(modelBuilder);
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
        private static void CreateMulk(ModelBuilder modelBuilder)
        {
            List<Mulk> mulks = DefaultMulks.MulkList();
            modelBuilder.Entity<Mulk>().HasData(mulks);
        }
        private static void CreateParaBirimi(ModelBuilder modelBuilder)
        {
            List<ParaBirimi> paraBirimis = DefaultParaBirimis.ParaBirimiList();
            modelBuilder.Entity<ParaBirimi>().HasData(paraBirimis);
        }
        
        private static void CreateIl(ModelBuilder modelBuilder)
        {
            List<Il> ils = DefaultIls.IlList();
            modelBuilder.Entity<Il>().HasData(ils);
        }
        private static void CreateIlce(ModelBuilder modelBuilder)
        {
            List<Ilce> ilces = DefaultIlces.IlceList();
            modelBuilder.Entity<Ilce>().HasData(ilces);
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
