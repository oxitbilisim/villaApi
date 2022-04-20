using Jemus.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Jemus.Persistence
{
    public interface IAppDbContext 
    {
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuPermission> MenuPermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<UserGroup> UserGrup { get; set; }
        public DbSet<files_merkez> files_merkez { get; set; }

        public DbSet<IdentityUserClaim<string>> UserClaims { get; set; }
        public DbSet<IdentityRoleClaim<string>> RoleClaims { get; set; }

        Task<int> SaveChangesAsync();
    }
}
