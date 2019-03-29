using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Account.Data.Entities.Security
{
    public class Role : EntityComparableStored<Guid>
    {
        public string Name { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { get; set; }

        public Role() : base()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public static Role Sa =>
            new Role()
            {
                Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                Name = "sa",
            };

        public static Role DefaultUser =>
           new Role()
           {
               Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
               Name = "user",
           };

        public static Role System =>
           new Role()
           {
               Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
               Name = "system",
           };
    }
}
