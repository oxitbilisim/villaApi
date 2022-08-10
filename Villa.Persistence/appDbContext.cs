using Villa.Domain.Auth;
using Villa.Domain.Entities;
using Villa.Persistence.Mapper;
using Villa.Persistence.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<MenuPermission> MenuPermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<IdentityUserClaim<string>> UserClaim { get; set; }
        public DbSet<IdentityRoleClaim<string>> RoleClaim { get; set; }
        public DbSet<IdentityUserRole<string>> UserRole { get; set; }
        public DbSet<Bolge> Bolge { get; set; }
        public DbSet<Etiket> Etiket { get; set; }
        public DbSet<EtiketDetay> EtiketDetay { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Mulk> Mulk { get; set; }
        public DbSet<Ozellik> Ozellik { get; set; }
        public DbSet<ParaBirimi> ParaBirimi { get; set; }
        public DbSet<PeriyodikFiyat> PeriyodikFiyat { get; set; }
        
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
        public DbSet<RezervasyonMisafir> RezervasyonMisafir { get; set; }
        public DbSet<RezervasyonOperasyon> RezervasyonOperasyon { get; set; }
        public DbSet<RezervasyonMaliBilgi> RezervasyonMaliBilgi { get; set; }
        
        
        public DbSet<PeriyodikFiyatAyarlari> PeriyodikFiyatAyarlari { get; set; }
        public DbSet<Villa.Domain.Entities.Villa> Villa { get; set; }
        public DbSet<VillaGorunum> VillaGorunum { get; set; }
        public DbSet<VillaImageDetay> VillaImageDetay { get; set; }
        public DbSet<VillaGosterim> VillaGosterim { get; set; }
        public DbSet<VillaImage> VillaImage { get; set; }
        public DbSet<VillaSahip> VillaSahip { get; set; }
        public DbSet<VillaKategori> VillaKategori { get; set; }
        public DbSet<VillaOzellik> VillaOzellik { get; set; }
        public DbSet<VillaSeo> VillaSeo { get; set; }
        public DbSet<VillaIcerik> VillaIcerik { get; set; }
        public DbSet<VillaLokasyon> VillaLokasyon { get; set; }
        public DbSet<Collections> Collections { get; set; }
        public DbSet<CollectionVillas> CollectionVillas { get; set; }
        
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogSeo> BlogSeo { get; set; }
        public DbSet<BlogKategori> BlogKategori { get; set; }
        public DbSet<BlogIcerik> BlogIcerik { get; set; }
        public DbSet<Sayfa> Sayfa { get; set; }
        public DbSet<SayfaIcerik> SayfaIcerik { get; set; }
        public DbSet<SayfaSeo> SayfaSeo { get; set; }
        public DbSet<ExchangeRates> ExchangeRates { get; set; }
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
            PermissionMapper.Initialize(modelBuilder);
            MenuPermissionMapper.Initialize(modelBuilder);
            PermissionMapper.Initialize(modelBuilder);
            BolgeMapper.Initialize(modelBuilder);
            IlMapper.Initialize(modelBuilder);
            VillaMapper.Initialize(modelBuilder);
            IlceMapper.Initialize(modelBuilder);
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseNpgsql("Host=185.122.203.197;Database=oxitvilla;Username=postgres;Password=oxit2016");
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
