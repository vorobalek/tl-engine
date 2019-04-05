using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.EntityFramework.Telegram.System.TgBots
{
    public class TgBotConfiguration : IEntityTypeConfiguration<TgBot>
    {
        public void Configure(EntityTypeBuilder<TgBot> builder)
        {
            builder
                .HasKey(e => new { e.Id });

            builder
                .HasIndex(e => new { e.Token, e.TypeName })
                .IsUnique();

            builder
                .Property(e => e.State)
                .HasDefaultValue(TgBotState.None);

            builder
                .HasMany(e => e.Connections)
                .WithOne(e => e.Bot)
                .HasForeignKey(e => e.BotId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}TgBots");
        }
    }
}