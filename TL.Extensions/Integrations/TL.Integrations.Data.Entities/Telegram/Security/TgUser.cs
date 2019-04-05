using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;
using TL.Integrations.Data.Entities.Telegram.Relationships;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgUser : EntityComparableStored<Guid>
    {
        public int TgId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public virtual IEnumerable<TgUserRole> UserRoles { get; set; }

        public virtual IEnumerable<TgConnection> Connections { get; set; }

        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public TgUser() : base()
        {
            UserRoles = new HashSet<TgUserRole>();
            Connections = new HashSet<TgConnection>();
        }
    }
}
