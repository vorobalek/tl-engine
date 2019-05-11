using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgRoles
{
    public class TgRoleConfiguration : IEntityTypeConfiguration<TgRole>
    {
        public void Configure(EntityTypeBuilder<TgRole> builder)
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
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.TgRoles");

            builder
                .HasData(new[]
                {
                    TgRole.Sa,
                    TgRole.Admin,
                    TgRole.User,
                    TgRole.System,
                });
        }
    }
}