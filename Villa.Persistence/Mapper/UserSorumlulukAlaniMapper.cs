
using Villa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Villa.Persistence.Mapper
{
    class UserSorumlulukAlaniMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSorumlulukAlani>(x =>
            {
                x.HasKey(x => x.Id);
                x.HasOne(c => c.SorumlulukAlani).WithMany(c => c.UserSorumlulukAlani).HasForeignKey(c => c.SorumlulukAlaniId).IsRequired();
                x.HasOne(c => c.User).WithMany(c => c.UserSorumlulukAlani).HasForeignKey(c => c.UserId).IsRequired();
            });
        }
    }
}
