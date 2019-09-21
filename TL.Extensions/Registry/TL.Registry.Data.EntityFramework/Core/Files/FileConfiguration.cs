using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.EntityFramework.Core.Files
{
    internal class FileConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder
                .HasIndex(e => e.Id);

            builder
                .HasIndex(e => e.Name);

            builder
                .HasOne(e => e.StaticFile)
                .WithOne()
                .HasForeignKey<File>(e => e.FileId);

            builder
                .HasOne(e => e.Folder)
                .WithMany(e => e.Files)
                .HasForeignKey(e => e.FolderId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.files");
        }
    }
}