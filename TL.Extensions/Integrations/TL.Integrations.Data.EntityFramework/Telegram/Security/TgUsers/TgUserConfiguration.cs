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
                .HasMany(e => e.Referrals)
                .WithOne(e => e.Referrer)
                .HasForeignKey(e => e.ReferrerId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}TgUsers");
        }
    }
}