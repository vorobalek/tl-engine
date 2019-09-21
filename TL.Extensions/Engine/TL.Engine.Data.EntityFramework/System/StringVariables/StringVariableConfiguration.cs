using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Entities.System;

namespace TL.Engine.Data.EntityFramework.System.StringVariables
{
    internal class StringVariableConfiguration : IEntityTypeConfiguration<StringVariable>
    {
        public void Configure(EntityTypeBuilder<StringVariable> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Name);

            builder
                .Property(e => e.AuthorId)
                .HasDefaultValue(User.System.Id);

            builder
                .HasOne(e => e.Author)
                .WithMany()
                .HasForeignKey(e => e.AuthorId);

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}.string.variables");
        }
    }
}
