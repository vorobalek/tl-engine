using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Engine.Data.Entities.System;

namespace TL.Engine.Data.EntityFramework.System
{
    public class StringVariableRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<StringVariable>(etb =>
            {
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id);

                etb.HasIndex(e => e.Name).IsUnique();
                etb.Property(e => e.Name);

                etb.Property(e => e.Value);

                etb.ToTable($"{EF_REGISTRATIONS.PREFIX}StringVariables");
            });
        }
    }
}
