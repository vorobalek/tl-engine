using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Data.EntityFramework.Security.Groups
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Name)
                .IsUnique();

            builder
                .HasMany(e => e.UserGroups)
                .WithOne(e => e.Group)
                .HasForeignKey(e => e.GroupId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}_Groups");

            builder
                .HasData(new[]
                {
                    Group.Sa,
                    Group.All,
                    Group.DefaultUser,
                    Group.System,
                });
        }
    }
}
