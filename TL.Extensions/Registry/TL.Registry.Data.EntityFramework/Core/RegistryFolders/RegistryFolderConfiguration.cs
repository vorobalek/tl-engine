using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.EntityFramework.Core.RegistryFolders
{
    internal class RegistryFolderConfiguration : IEntityTypeConfiguration<RegistryFolder>
    {
        public void Configure(EntityTypeBuilder<RegistryFolder> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.Owner)
                .WithMany()
                .HasForeignKey(e => e.OwnerId);

            builder
                .HasMany(e => e.Folders)
                .WithOne(e => e.Parant)
                .HasForeignKey(e => e.ParantId)
                .OnDelete(DeleteBehavior.Restrict);

            ///

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.RegistryFolders");
        }
    }
}