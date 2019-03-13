using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using TL.Crm.Data.Entities.Core;

namespace TL.Crm.Data.EntityFramework.Core.Contractors
{
    public class ContractorConfiguration : IEntityTypeConfiguration<Contractor>
    {
        public void Configure(EntityTypeBuilder<Contractor> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasMany(e => e.Leads)
                .WithOne(e => e.Contractor)
                .HasForeignKey(e => e.ContractorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(e => e.Invites)
                .WithOne(e => e.Referrer)
                .HasForeignKey(e => e.ReferrerId);

            builder
               .HasOne(e => e.Original as Contractor)
               .WithMany(e => e.Duplicates)
               .HasForeignKey(e => e.OriginalId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasData(new[]
                {
                    Contractor.System,
                });

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Contractors");
        }
    }
}