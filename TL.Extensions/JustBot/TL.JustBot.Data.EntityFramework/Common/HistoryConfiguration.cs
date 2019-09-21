using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.JustBot.Data.Entities.Common;

namespace TL.JustBot.Data.EntityFramework.Common
{
    internal class HistoryConfiguration : IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.Author)
                .WithMany(e => e.History)
                .HasForeignKey(e => e.AuthorId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.history");
        }
    }
}