using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace TL.Account.Data.Entities.Secutiry
{
    public class Role : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public Role()
        {
            Users = new HashSet<User>();
        }

        public static Role Sa => 
            new Role()
            {
                Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                Name = "sa",
            };

        public static Role User =>
           new Role()
           {
               Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
               Name = "user",
           };
    }
}
