using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Data.EntityFramework.Security.Roles
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Name)
                .IsUnique();

            builder
                .HasMany(e => e.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(e => e.RoleId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.Roles");

            builder
                .HasData(new[]
                {
                    Role.Sa,
                    Role.DefaultUser,
                    Role.System,
                });
        }
    }
}
