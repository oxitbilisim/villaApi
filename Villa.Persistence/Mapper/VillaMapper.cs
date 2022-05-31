
using Villa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Villa.Persistence.Mapper
{
    class VillaMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Villa>(x =>
            {
                x.HasMany(c => c.PeriyodikFiyat).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaGorunum).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaGosterim).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaIcerik).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaImage).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaKategori).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaLokasyon).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaOzellik).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaSeo).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.VillaSeo).WithOne(c => c.Villa).HasForeignKey(t => t.VillaId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasOne(c => c.Mulk).WithMany(c => c.Villa).HasForeignKey(t => t.MulkId);
            });
        }
    }
}
