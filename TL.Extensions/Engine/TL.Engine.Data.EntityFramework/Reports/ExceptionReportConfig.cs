using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Engine.Data.Entities.Reports;

namespace TL.Engine.Data.EntityFramework.Reports
{
    public class ExceptionReportConfig : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Date);

            builder
                .HasIndex(e => e.Message);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}ExceptionReports");
        }
    }
}
