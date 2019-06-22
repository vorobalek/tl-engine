using System;
using System.Collections.Generic;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.Security
{
    public class Group : EntityComparableStored<Guid>
    {
        [StringIndex]
        public string Name { get; set; }

        public virtual IEnumerable<UserGroup> UserGroups { get; set; }

        public Group() : base()
        {
            UserGroups = new HashSet<UserGroup>();
        }

        public static Group All =>
            new Group()
            {
                Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                Name = "all",
            };

        public static Group Sa =>
            new Group()
            {
                Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                Name = "sa",
            };

        public static Group DefaultUser =>
           new Group()
           {
               Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
               Name = "user",
           };

        public static Group System =>
           new Group()
           {
               Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
               Name = "system",
           };
    }
}