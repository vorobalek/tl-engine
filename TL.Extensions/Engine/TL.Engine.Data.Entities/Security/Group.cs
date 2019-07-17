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
                Id = Guid.Parse("81d73ef6-da15-43ab-8f6d-d9663d9e2822"),
                Name = "all",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Group Sa =>
            new Group()
            {
                Id = Guid.Parse("046b7820-848e-4aa4-8569-6d2e94c909b3"),
                Name = "sa",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Group DefaultUser =>
           new Group()
           {
               Id = Guid.Parse("92581db6-0e31-4669-a77d-1730f464b005"),
               Name = "user",
               CreationDate = DateTime.UnixEpoch,
               ModifiedDate = DateTime.UnixEpoch
           };

        public static Group System =>
           new Group()
           {
               Id = Guid.Parse("17e61588-323e-49ea-8edf-d77a059d70eb"),
               Name = "system",
               CreationDate = DateTime.UnixEpoch,
               ModifiedDate = DateTime.UnixEpoch
           };
    }
}