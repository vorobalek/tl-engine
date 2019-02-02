using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.Users
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Username)
                .IsUnique();

            builder
                .HasOne(e => e.Referrer)
                .WithMany(e => e.Referrals)
                .HasForeignKey(e => e.ReferrerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            builder
                .HasMany(e => e.Subscriptions)
                .WithOne(e => e.From)
                .HasForeignKey(e => e.FromId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Users");

            builder
                .HasData(new[]
                {
                    User.Sa,
                    User.System
                });
        }
    }
}
