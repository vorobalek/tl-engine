using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.JustBot.Data.Entities.Security;

namespace TL.JustBot.Data.EntityFramework.Security
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Token)
                .IsUnique();

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.Person");
        }
    }
}