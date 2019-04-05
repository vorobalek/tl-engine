using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Engine.Data.Entities.System;

namespace TL.Engine.Data.EntityFramework.System.StaticFiles
{
    public class StaticFileConfiguration : IEntityTypeConfiguration<StaticFile>
    {
        public void Configure(EntityTypeBuilder<StaticFile> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.Original)
                .WithMany(e => e.Duplicates)
                .HasForeignKey(e => e.OriginalId);

            builder
                .HasOne(e => e.Author)
                .WithMany()
                .HasForeignKey(e => e.AuthorId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}StaticFiles");
        }
    }
}