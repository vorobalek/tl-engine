using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TL.Registry.Data.EntityFramework.Core.Registries
{
    internal class RegistryConfiguration : IEntityTypeConfiguration<Entities.Core.Registry>
    {
        public void Configure(EntityTypeBuilder<Entities.Core.Registry> builder)
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
                .HasOne(e => e.Root)
                .WithMany(e => e.Registries)
                .HasForeignKey(e => e.RootId);

            builder
                .HasMany(e => e.UserPermissions)
                .WithOne(e => e.Object)
                .HasForeignKey(e => e.ObjectId);

            builder
                .HasMany(e => e.GroupPermissions)
                .WithOne(e => e.Object)
                .HasForeignKey(e => e.ObjectId);

            builder
                .HasMany(e => e.RolePermissions)
                .WithOne(e => e.Object)
                .HasForeignKey(e => e.ObjectId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.Registries");
        }
    }
}