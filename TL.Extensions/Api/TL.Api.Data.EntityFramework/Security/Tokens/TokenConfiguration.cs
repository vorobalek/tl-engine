using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Api.Data.Entities.Security;

namespace TL.Api.Data.EntityFramework.Security.Tokens
{
    public class TokenConfiguration : IEntityTypeConfiguration<Token>
    {
        public void Configure(EntityTypeBuilder<Token> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.Owner)
                .WithMany()
                .HasForeignKey(e => e.OwnerId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.Tokens");
        }
    }
}