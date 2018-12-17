using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace TL.Account.Data.Entities.Secutiry
{
    public class Role : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }

        public static Role SA => 
            new Role()
            {
                Id = Guid.Parse("2e8036a5-95d2-4137-996e-a72d559d09a4"),
                Name = "SA",
            };
    }
}
