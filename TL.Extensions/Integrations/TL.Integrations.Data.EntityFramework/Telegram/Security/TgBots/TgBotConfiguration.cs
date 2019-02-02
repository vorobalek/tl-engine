using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgBots
{
    public class TgBotConfiguration : IEntityTypeConfiguration<TgBot>
    {
        public void Configure(EntityTypeBuilder<TgBot> builder)
        {
            builder
                .HasKey(e => new { e.Id });

            builder
                .HasIndex(e => new { e.Token, e.Username, e.TypeName })
                .IsUnique();

            builder
                .HasMany(e => e.Connections)
                .WithOne(e => e.Bot)
                .HasForeignKey(e => e.BotId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}TgBots");
        }
    }
}