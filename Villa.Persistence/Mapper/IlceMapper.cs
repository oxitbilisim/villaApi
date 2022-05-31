
using Villa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Villa.Persistence.Mapper
{
    class IlceMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ilce>(x =>
            {
                x.HasOne(c => c.Il).WithMany(c => c.Ilce).HasForeignKey(c => c.IlId).IsRequired(true);
            });
        }
    }
}
