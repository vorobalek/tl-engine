using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TL.Engine.Data.Entities.System;

namespace TL.Engine.Data.EntityFramework.System
{
    public class StringVariableConfig : IEntityTypeConfiguration<StringVariable>
    {
        public void Configure(EntityTypeBuilder<StringVariable> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasIndex(e => e.Name)
                .IsUnique();

            builder
                .ToTable($"{EF_REGISTRATIONS.PREFIX}StringVariables");
        }
    }
}
