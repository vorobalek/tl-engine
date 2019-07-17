using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.GroupPermissions
{
    internal class GroupPermissionConfiguration : IEntityTypeConfiguration<GroupPermission>
    {
        public void Configure(EntityTypeBuilder<GroupPermission> builder)
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
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.RegistriesGroupPermissions");
        }
    }
}