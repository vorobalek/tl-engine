using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Account.Data.Entities.Relationships;

namespace TL.Account.Data.EntityFramework.Relationships.Subscriptions
{
    internal class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder
                .Ignore(e => e.Id);

            builder
                .HasKey(e => new { e.FromId, e.ToId });

            builder
                .HasOne(e => e.From)
                .WithMany()
                .HasForeignKey(e => e.FromId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.Subscriptions");

            builder
                .HasData(new[]
                { 
                    Subscription.SaToSystem,
                    Subscription.DefaultUserToSystem
                });
        }
    }
}