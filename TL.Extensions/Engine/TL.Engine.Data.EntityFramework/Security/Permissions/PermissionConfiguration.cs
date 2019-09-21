using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Engine.SDK.Types;

namespace TL.Engine.Data.EntityFramework.Security.Permissions
{
    internal class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder
                .HasKey(e => new { e.SubjectId, e.ObjectId });

            builder
                .Ignore(e => e.Id);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.permissions");
        }
    }
}