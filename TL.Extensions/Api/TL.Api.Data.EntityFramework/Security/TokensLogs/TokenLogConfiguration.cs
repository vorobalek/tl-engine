using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Api.Data.Entities.Security;

namespace TL.Api.Data.EntityFramework.Security.TokensLogs
{
    public class TokenLogConfiguration : IEntityTypeConfiguration<TokenLog>
    {
        public void Configure(EntityTypeBuilder<TokenLog> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId);

            builder
                .HasOne(e => e.Token)
                .WithMany(e => e.Logs)
                .HasForeignKey(e => e.TokenId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.TokensLogs");
        }
    }
}