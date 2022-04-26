using Jemus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jemus.Persistence.Mapper
{
    class PermissionMapper
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>(x =>
            {
                x.HasMany(c => c.MenuPermission).WithOne(c => c.Permission).HasForeignKey(c => c.PermissionId).HasConstraintName("FK_Permission_MenuPermission").IsRequired(true);
            });
        }
    }
}
