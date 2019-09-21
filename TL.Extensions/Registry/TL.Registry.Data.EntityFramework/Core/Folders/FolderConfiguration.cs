using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.EntityFramework.Core.Folders
{
    internal class FolderConfiguration : IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Name);

            builder
                .HasOne(e => e.Owner)
                .WithMany()
                .HasForeignKey(e => e.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(e => e.Folders)
                .WithOne(e => e.Parant)
                .HasForeignKey(e => e.ParantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(e => e.Registries)
                .WithOne(e => e.Root)
                .HasForeignKey(e => e.RootId);

            builder
                .HasMany(e => e.Files)
                .WithOne(e => e.Folder)
                .HasForeignKey(e => e.FolderId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.folders");
        }
    }
}