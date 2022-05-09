
using Villa.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Villa.Persistence.Mapper
{
    class MenuMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(x =>
            {
                x.HasMany(c => c.items).WithOne(c => c.ParentMenu).HasForeignKey(t => t.ParentMenuId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
                x.HasMany(c => c.MenuPermission).WithOne(c => c.Menu).HasForeignKey(c => c.MenuId).IsRequired(true);
            });
        }
    }
}
