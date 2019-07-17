using System;
using System.Collections.Generic;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.Security
{
    public class Role : EntityComparableStored<Guid>
    {
        [StringIndex]
        public string Name { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { get; set; }

        public Role() : base()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public static Role Sa =>
            new Role()
            {
                Id = Guid.Parse("f22de7e3-aebb-4bde-845b-6702a4a92682"),
                Name = "sa",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Role DefaultUser =>
           new Role()
           {
               Id = Guid.Parse("9a2814f7-b6c9-481d-882b-f5f5be4a5a89"),
               Name = "user",
               CreationDate = DateTime.UnixEpoch,
               ModifiedDate = DateTime.UnixEpoch
           };

        public static Role System =>
           new Role()
           {
               Id = Guid.Parse("6b68805b-1245-4f47-b2e9-5d3adc687798"),
               Name = "system",
               CreationDate = DateTime.UnixEpoch,
               ModifiedDate = DateTime.UnixEpoch
           };
    }
}
