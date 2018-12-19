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
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Users");

            builder
                .HasData(new[]
                {
                    User.Sa
                });
        }
    }
}
