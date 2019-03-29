using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgRole : EntityComparableStored<Guid>
    {
        public string Name { get; set; }

        public virtual IEnumerable<TgUserRole> UserRoles { get; set; }

        public TgRole() : base()
        {
            UserRoles = new HashSet<TgUserRole>();
        }

        public static TgRole Sa =>
            new TgRole()
            {
                Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                Name = "sa",
            };

        public static TgRole Admin =>
            new TgRole()
            {
                Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                Name = "admin",
            };

        public static TgRole User =>
           new TgRole()
           {
               Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
               Name = "user",
           };

        public static TgRole System =>
           new TgRole()
           {
               Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
               Name = "system",
           };
    }
}
