using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Account.Data.Entities.Relationships
{
    public class Subscription : EntityComparableStored<(Guid, Guid)>
    {
        public Guid FromId { get; set; }

        public virtual User From { get; set; }

        public Guid ToId { get; set; }

        public bool Quiet { get; set; } = false;

        public static Subscription SaToSystem =>
            new Subscription()
            {
                FromId  = User.Sa.Id,
                ToId = User.System.Id
            };

        public static Subscription DefaultUserToSystem =>
            new Subscription()
            {
                FromId = User.DefaultUser.Id,
                ToId = User.System.Id
            };
    }
}
