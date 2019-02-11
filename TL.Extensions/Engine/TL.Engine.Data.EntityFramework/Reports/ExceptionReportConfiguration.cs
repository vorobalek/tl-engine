using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Engine.Data.Entities.Reports;

namespace TL.Engine.Data.EntityFramework.Reports
{
    public class ExceptionReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.CreationDate);

            builder
                .HasIndex(e => e.ModifiedDate);

            builder
                .HasIndex(e => e.Message);

            builder
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}ExceptionReports");
        }
    }
}
