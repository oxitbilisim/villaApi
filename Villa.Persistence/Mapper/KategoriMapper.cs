
using Villa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Villa.Persistence.Mapper
{
    class KategoriMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>(x =>
            {
                x.HasMany(c => c.items).WithOne(c => c.ParentKategori).HasForeignKey(t => t.ParentKategoriId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
