
using Villa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Villa.Persistence.Mapper
{
    class IlMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Il>(x =>
            {
                x.HasMany(c => c.Bolge).WithOne(c => c.Il).HasForeignKey(t => t.IlId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
