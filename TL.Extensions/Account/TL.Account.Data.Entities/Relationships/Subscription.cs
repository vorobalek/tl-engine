using ExtCore.Data.Entities.Abstractions;
using System;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.Entities.Relationships
{
    public class Subscription : IEntity
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
    }
}
