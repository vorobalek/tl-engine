using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.UsersRoles
{
    public class UserRoleRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<UserRole>()
                .HasKey(e => new { e.UserId, e.RoleId });

            modelbuilder.Entity<UserRole>()
                .ToTable($"{EF_REGISTRATIONS.PREFIX}UsersRoles");

            modelbuilder.Entity<UserRole>()
                .HasData(new[]
                {
                    UserRole.Sa
                });
        }
    }
}
