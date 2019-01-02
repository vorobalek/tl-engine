using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Translator.Data.Entities.Translations;

namespace TL.Translator.Data.EntityFramework.Translations
{
    public class TranslationConfig : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Date);
            builder.ToTable($"{EF_REGISTRATIONS.PREFIX}Translations");
        }
    }
}