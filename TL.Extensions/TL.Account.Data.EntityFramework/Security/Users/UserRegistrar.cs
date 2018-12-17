using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using TL.Account.Data.Entities.Secutiry;

namespace TL.Account.Data.EntityFramework.Security.Users
{
    public class UserRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>(etb =>
            {
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id);

                etb.HasIndex(e => e.Username).IsUnique();
                etb.Property(e => e.Username);

                etb.Property(e => e.PasswordHash);

                etb.ToTable($"{EF_REGISTRATIONS.PREFIX}Users");
            });

            modelbuilder.Entity<User>().HasData(User.SA);
        }
    }
}
