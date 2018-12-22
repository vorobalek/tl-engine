using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace TL.Account.Data.Entities.Security
{
    public class Role : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { get; set; }

        public Role()
        {
            UserRoles = new HashSet<UserRole>();
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
