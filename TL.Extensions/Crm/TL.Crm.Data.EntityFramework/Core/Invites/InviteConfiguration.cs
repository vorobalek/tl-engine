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
                .HasOne(e => e.Referrer)
                .WithMany(e => e.Invites)
                .HasForeignKey(e => e.ReferrerId);

            builder
                .HasOne(e => e.Referral)
                .WithOne()
                .HasForeignKey<Invite>(e => e.ReferralId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Invites");
        }
    }
}