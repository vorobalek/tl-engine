using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Crm.Data.Entities.Core;

namespace TL.Crm.Data.EntityFramework.Core.Leads
{
    public class LeadConfiguration : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(e => e.Contractor)
                .WithMany(e => e.Leads)
                .HasForeignKey(e => e.ContractorId);

            builder
                .HasMany(e => e.Phones)
                .WithOne(e => e.Lead)
                .HasForeignKey(e => e.LeadId);

            builder
                .HasOne(e => e.Original)
                .WithMany(e => e.Dublicates)
                .HasForeignKey(e => e.OriginalId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Leads");
        }
    }
}