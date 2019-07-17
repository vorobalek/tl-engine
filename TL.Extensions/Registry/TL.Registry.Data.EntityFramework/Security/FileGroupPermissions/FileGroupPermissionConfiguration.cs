using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.FileGroupPermissions
{
    internal class FileGroupPermissionConfiguration : IEntityTypeConfiguration<FileGroupPermission>
    {
        public void Configure(EntityTypeBuilder<FileGroupPermission> builder)
        {
            builder
                .Ignore(e => e.Id);

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
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.FilesGroupPermissions");
        }
    }
}