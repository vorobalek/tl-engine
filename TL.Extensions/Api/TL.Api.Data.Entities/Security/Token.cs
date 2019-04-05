using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Api.Data.Entities.Security
{
    public class Token : EntityComparableStored<Guid>
    {
        public Guid? OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public IEnumerable<TokenLog> Logs { get; set; }

        public Token()
        {
            Logs = new HashSet<TokenLog>();
        }
    }
}
