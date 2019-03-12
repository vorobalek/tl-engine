using System;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Api.Data.Entities.Security
{
    public class Token : EntityComparableStored<Guid>
    {
        public Guid? OwnerId { get; set; }

        public virtual User Owner { get; set; }
    }
}
