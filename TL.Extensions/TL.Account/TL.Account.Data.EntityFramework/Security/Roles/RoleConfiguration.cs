using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.Roles
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Name)
                .IsUnique();

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Roles");

            builder
                .HasData(new[]
                {
                    Role.Sa,
                    Role.User
                });
        }
    }
}
