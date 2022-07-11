using Villa.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Villa.Persistence
{
    public interface IAppDbContext 
    {
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuPermission> MenuPermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<IdentityUserClaim<string>> UserClaims { get; set; }
        public DbSet<IdentityRoleClaim<string>> RoleClaims { get; set; }
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
        public DbSet<RezervasyonMisafir> RezervasyonMisafir { get; set; }
        public DbSet<RezervasyonOperasyon> RezervasyonOperasyon { get; set; }
        public DbSet<RezervasyonMaliBilgi> RezervasyonMaliBilgi { get; set; }
        public DbSet<Bolge> Bolge { get; set; }
        public DbSet<Etiket> Etiket { get; set; }
        public DbSet<EtiketDetay> EtiketDetay { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Mulk> Mulk { get; set; }
        public DbSet<Ozellik> Ozellik { get; set; }
        public DbSet<ParaBirimi> ParaBirimi { get; set; }
        public DbSet<PeriyodikFiyat> PeriyodikFiyat { get; set; }
        
        public DbSet<PeriyodikFiyatAyarlari> PeriyodikFiyatAyarlari { get; set; }
        public DbSet<Villa.Domain.Entities.Villa> Villa { get; set; }
        public DbSet<VillaGorunum> VillaGorunum { get; set; }
        public DbSet<VillaGosterim> VillaGosterim { get; set; }
        public DbSet<VillaImage> VillaImage { get; set; }
        public DbSet<VillaKategori> VillaKategori { get; set; }
        public DbSet<VillaOzellik> VillaOzellik { get; set; }
        public DbSet<VillaSeo> VillaSeo { get; set; }
        public DbSet<VillaIcerik> VillaIcerik { get; set; }
        public DbSet<VillaLokasyon> VillaLokasyon { get; set; }

        Task<int> SaveChangesAsync();
    }
}
