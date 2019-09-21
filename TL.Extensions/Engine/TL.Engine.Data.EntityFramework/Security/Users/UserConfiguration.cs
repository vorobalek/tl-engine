using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Data.EntityFramework.Security.Users
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Username)
                .IsUnique();

            builder
                .HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            builder
                .HasMany(e => e.UserGroups)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.users");

            builder
                .HasData(new[]
                {
                    User.Sa,
                    User.DefaultUser,
                    User.System
                });
        }
    }
}
