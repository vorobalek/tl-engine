using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.Roles
{
    public class RoleRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Role>()
                .HasKey(e => e.Id);

            modelbuilder.Entity<Role>()
                .HasIndex(e => e.Name)
                .IsUnique();

            modelbuilder.Entity<Role>()
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Roles");

            modelbuilder.Entity<Role>()
                .HasData(new[]
                {
                    Role.Sa,
                    Role.User
                });
        }
    }
}
