
using Villa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Villa.Persistence.Mapper
{
    class BolgeMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bolge>(x =>
            {
                   x.HasOne(c => c.Il).WithMany(c => c.Bolge).HasForeignKey(c => c.IlId).IsRequired(true);
            });
        }
    }
}
