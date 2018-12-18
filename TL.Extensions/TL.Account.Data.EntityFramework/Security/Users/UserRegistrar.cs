using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.Users
{
    public class UserRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>()
                .HasKey(e => e.Id);

            modelbuilder.Entity<User>()
                .HasIndex(e => e.Username)
                .IsUnique();

            modelbuilder.Entity<User>()
                .ToTable($"{EF_REGISTRATIONS.PREFIX}Users");

            modelbuilder.Entity<User>()
                .HasData(new[]
                {
                    User.Sa
                });
        }
    }
}
