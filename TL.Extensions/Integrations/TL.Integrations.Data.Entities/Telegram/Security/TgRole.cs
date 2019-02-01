using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgRole : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<TgUserRole> UserRoles { get; set; }

        public TgRole()
        {
            UserRoles = new HashSet<TgUserRole>();
        }

        public static TgRole Sa =>
            new TgRole()
            {
                Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                Name = "sa",
            };

        public static TgRole User =>
           new TgRole()
           {
               Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
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
