using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Linker.Data.Entities.Core;

namespace TL.Linker.Data.EntityFramework.Core.Links
{
    public class LinkConfiguration : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Identifier)
                .IsUnique();

            builder
                .HasIndex(e => e.Url)
                .IsUnique();

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Links");
        }
    }
}