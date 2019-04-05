using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Account.Data.Entities.Relationships;

namespace TL.Account.Data.EntityFramework.Relationships.Subscriptions
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder
                .HasKey(e => new { e.FromId, e.ToId });

            builder
                .HasOne(e => e.From)
                .WithMany()
                .HasForeignKey(e => e.FromId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}_Subscriptions");

            builder
                .HasData(new[]
                { 
                    Subscription.SaToSystem,
                });
        }
    }
}