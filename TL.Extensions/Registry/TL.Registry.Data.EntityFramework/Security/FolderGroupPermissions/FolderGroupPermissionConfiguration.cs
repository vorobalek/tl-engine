using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.FolderGroupPermissions
{
    internal class FolderGroupPermissionConfiguration : IEntityTypeConfiguration<FolderGroupPermission>
    {
        public void Configure(EntityTypeBuilder<FolderGroupPermission> builder)
        {
            builder
                .HasKey(e => new { e.ObjectId, e.SubjectId });

            builder
                .HasOne(e => e.Object)
                .WithMany(e => e.GroupPermissions)
                .HasForeignKey(e => e.ObjectId);

            builder
                .HasOne(e => e.Subject)
                .WithMany()
                .HasForeignKey(e => e.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.FoldersGroupPermissions");
        }
    }
}