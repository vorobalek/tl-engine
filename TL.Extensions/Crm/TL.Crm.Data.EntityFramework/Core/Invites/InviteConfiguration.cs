using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
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
                .Property(e => e.MaxMembersCount)
                .HasDefaultValue(1);

            builder
                .Property(e => e.TimeOut)
                .HasDefaultValue(DateTime.MaxValue);

            builder
                .Property(e => e.ReferrerId)
                .HasDefaultValue(Contractor.System.Id);

            builder
                .HasOne(e => e.Referrer)
                .WithMany(e => e.Invites)
                .HasForeignKey(e => e.ReferrerId);

            builder
                .HasMany(e => e.Referrals)
                .WithOne(e => e.Invite)
                .HasForeignKey(e => e.InviteId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Invites");
        }
    }
}