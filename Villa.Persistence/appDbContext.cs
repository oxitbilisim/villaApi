using Villa.Domain.Auth;
using Villa.Domain.Entities;
using Villa.Domain.Enum;
using Villa.Entities.Models;
using Villa.Persistence.Mapper;
using Villa.Persistence.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Threading.Tasks;

namespace Villa.Persistence
{
    public class appDbContext :  IdentityDbContext<User, IdentityRole, string> , IAppDbContext
    {
        // This constructor is used of runit testing
        public appDbContext()
        {
        }
        public appDbContext(DbContextOptions<appDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<SorumlulukAlani> SorumlulukAlani { get; set; }
        public DbSet<UserSorumlulukAlani> UserSorumlulukAlani { get; set; }
        public DbSet<MenuPermission> MenuPermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<files_merkez> files_merkez { get; set; }    
        public DbSet<IdentityUserClaim<string>> UserClaim { get; set; }
        public DbSet<IdentityRoleClaim<string>> RoleClaim { get; set; }
        public DbSet<IdentityUserRole<string>> UserRole { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Identity
            modelBuilder.Entity<IdentityUserToken<string>>(x =>
            {
                x.ToTable("UserToken");
                x.HasKey(c => new { c.UserId, c.Value });
            });
            modelBuilder.Entity<IdentityUserRole<string>>(x =>
            {
                x.ToTable("UserRole");
                x.HasKey(c => new { c.UserId, c.RoleId });
            });
            modelBuilder.Entity<User>(x =>
            {
                x.ToTable("User");
                x.HasKey(c => c.Id);
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(x =>
            {
                x.ToTable("UserLogin");
                x.HasKey(c => new { c.UserId, c.ProviderKey });
            });
            modelBuilder.Entity<IdentityUserClaim<string>>(x =>
            {
                x.ToTable("UserClaim");
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(x =>
            {
                x.ToTable("RoleClaim");
            });
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            #endregion

            MenuMapper.Initialize(modelBuilder);
            SorumlulukAlaniMapper.Initialize(modelBuilder);
            PermissionMapper.Initialize(modelBuilder);
            MenuPermissionMapper.Initialize(modelBuilder);
            PermissionMapper.Initialize(modelBuilder);
            UserSorumlulukAlaniMapper.Initialize(modelBuilder);

            //modelBuilder.Entity<User>(entity =>
            //{
            //    entity.ToTable(name: "User");
            //});

            //modelBuilder.Entity<IdentityRole>(entity =>
            //{
            //    entity.ToTable(name: "Role");
            //});
            //modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            //{
            //    entity.ToTable("UserRoles");
            //});

            //modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            //{
            //    entity.ToTable("UserClaims");
            //});

            ////modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            ////{
            ////    entity.ToTable("UserLogins");
            ////});

            //modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            //{
            //    entity.ToTable("RoleClaims");
            //});

            //modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            //{
            //    entity.ToTable("UserTokens");
            // });
            //modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            //modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            //modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();

            modelBuilder.Entity<files_merkez>().HasNoKey();   

            modelBuilder
                .Entity<files_merkez>()
                .Property(d => d.sakincadurumu)
                .HasConversion(new EnumToStringConverter<SakincaDurumu>());

            modelBuilder
               .Entity<files_merkez>()
               .Property(d => d.islemtipi)
               .HasConversion(new EnumToStringConverter<IslemTipi>());

            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseNpgsql("DataSource=app.db");
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
