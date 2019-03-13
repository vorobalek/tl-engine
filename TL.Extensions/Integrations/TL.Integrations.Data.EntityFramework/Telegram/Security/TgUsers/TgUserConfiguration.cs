using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgUsers
{
    public class TgUserConfiguration : IEntityTypeConfiguration<TgUser>
    {
        public void Configure(EntityTypeBuilder<TgUser> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                 .HasMany(e => e.UserRoles)
                 .WithOne(e => e.User)
                 .HasForeignKey(e => e.UserId);

            builder
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(e => e.Connections)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}TgUsers");
        }
    }
}