using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
                .HasForeignKey(e => e.ContractorId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Contractors");
        }
    }
}