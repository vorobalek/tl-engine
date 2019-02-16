using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Crm.Data.Entities.Core;

namespace TL.Crm.Data.EntityFramework.Core.Invites
{
    public class InviteConfiguration : IEntityTypeConfiguration<Invite>
    {
        public void Configure(EntityTypeBuilder<Invite> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.Referral)
                .WithOne(e => e.Invite)
                .HasForeignKey<Lead>(e => e.InviteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Invites");
        }
    }
}