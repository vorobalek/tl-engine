using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Crm.Data.Entities.Periphery;

namespace TL.Crm.Data.EntityFramework.Periphery.Phones
{
    public class LeadPhoneConfiguration : IEntityTypeConfiguration<LeadPhone>
    {
        public void Configure(EntityTypeBuilder<LeadPhone> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.PhoneNumber);

            builder
                .HasOne(e => e.Lead)
                .WithMany(e => e.Phones)
                .HasForeignKey(e => e.LeadId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}LeadsPhones");
        }
    }
}