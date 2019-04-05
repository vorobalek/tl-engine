using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Integrations.Data.Entities.Telegram.Relationships;

namespace TL.Integrations.Data.EntityFramework.Telegram.Relationships.TgConnections
{
    public class TgConnectionConfiguration : IEntityTypeConfiguration<TgConnection>
    {
        public void Configure(EntityTypeBuilder<TgConnection> builder)
        {
            builder
                .HasKey(e => new { e.BotId, e.UserId });

            builder
                .HasOne(e => e.Bot)
                .WithMany(e => e.Connections)
                .HasForeignKey(e => e.BotId);

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.Connections)
                .HasForeignKey(e => e.UserId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}_TgConnections");
        }
    }
}