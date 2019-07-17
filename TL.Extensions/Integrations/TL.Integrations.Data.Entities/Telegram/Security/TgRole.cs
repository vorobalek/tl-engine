using System;
using System.Collections.Generic;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgRole : EntityComparableStored<Guid>
    {
        [StringIndex]
        public string Name { get; set; }

        public virtual IEnumerable<TgUserRole> UserRoles { get; set; }

        public TgRole() : base()
        {
            UserRoles = new HashSet<TgUserRole>();
        }

        public static TgRole Sa =>
            new TgRole()
            {
                Id = Guid.Parse("bc59f363-3d93-479c-97f6-8f9cc1fe3440"),
                Name = "sa",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static TgRole Admin =>
            new TgRole()
            {
                Id = Guid.Parse("3f83a69f-1fe3-4a10-b6a6-6ceb7e66367c"),
                Name = "admin",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static TgRole User =>
           new TgRole()
           {
               Id = Guid.Parse("c6682671-0238-492c-a871-db76d512a280"),
               Name = "user",
               CreationDate = DateTime.UnixEpoch,
               ModifiedDate = DateTime.UnixEpoch
           };

        public static TgRole System =>
           new TgRole()
           {
               Id = Guid.Parse("0e7012ab-115a-48b2-9291-3bb97b3712e8"),
               Name = "system",
               CreationDate = DateTime.UnixEpoch,
               ModifiedDate = DateTime.UnixEpoch
           };
    }
}
