using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Data.EntityFramework.Security.UsersRoles
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder
               .HasKey(e => new { e.UserId, e.RoleId });

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.UsersRoles");

            builder
                .HasOne(e => e.Role)
                .WithMany(e => e.UserRoles)
                .HasForeignKey(e => e.RoleId);

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.UserRoles)
                .HasForeignKey(e => e.UserId);

            builder
                .HasData(UserRole.Sa
                .Concat(UserRole.DefaultUser)
                .Concat(UserRole.System));
        }
    }
}
