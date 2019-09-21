using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgUsersRoles
{
    internal class TgUserRoleConfiguration : IEntityTypeConfiguration<TgUserRole>
    {
        public void Configure(EntityTypeBuilder<TgUserRole> builder)
        {
            builder
                .Ignore(e => e.Id);

            builder
               .HasKey(e => new { e.UserId, e.RoleId });

            builder
                .HasOne(e => e.Role)
                .WithMany(e => e.UserRoles)
                .HasForeignKey(e => e.RoleId);

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.UserRoles)
                .HasForeignKey(e => e.UserId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.tg.users.roles");
        }
    }
}