using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Data.EntityFramework.Security.UsersGroups
{
    internal class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> builder)
        {
            builder
                .Ignore(e => e.Id);

            builder
               .HasKey(e => new { e.UserId, e.GroupId });

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.UsersGroups");

            builder
                .HasOne(e => e.Group)
                .WithMany(e => e.UserGroups)
                .HasForeignKey(e => e.GroupId);

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.UserGroups)
                .HasForeignKey(e => e.UserId);

            builder
                .HasData(UserGroup.Sa
                .Concat(UserGroup.DefaultUser)
                .Concat(UserGroup.System));
        }
    }
}
