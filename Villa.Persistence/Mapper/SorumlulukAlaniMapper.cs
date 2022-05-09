
using Villa.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Villa.Persistence.Mapper
{
    class SorumlulukAlaniMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SorumlulukAlani>(x =>
            {
                x.HasMany(c => c.items).WithOne(c => c.ParentSorumlulukAlani).HasForeignKey(t => t.ParentSorumlulukAlaniId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.UserSorumlulukAlani).WithOne(c => c.SorumlulukAlani).HasForeignKey(t => t.SorumlulukAlaniId).IsRequired();
            });
        }
    }
}
