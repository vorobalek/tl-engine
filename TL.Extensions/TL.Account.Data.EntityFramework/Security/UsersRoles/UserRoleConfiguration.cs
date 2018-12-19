using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.UsersRoles
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder
               .HasKey(e => new { e.UserId, e.RoleId });

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}UsersRoles");

            builder
                .HasData(new[]
                {
                    UserRole.Sa
                });
        }
    }
}
