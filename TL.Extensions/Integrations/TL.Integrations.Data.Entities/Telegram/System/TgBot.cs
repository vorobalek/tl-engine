using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;
using TL.Integrations.Data.Entities.Telegram.Relationships;

namespace TL.Integrations.Data.Entities.Telegram.System
{
    public class TgBot : EntityComparableStored<Guid>
    {
        public string Token { get; set; }

        public string Username { get; set; }

        public string NativeName { get; set; }

        public string TypeName { get; set; }

        public bool SkipUpdates { get; set; }

        public bool AutoStart { get; set; }

        public bool IsRelevant { get; set; }

        public DateTime? LastStartDate { get; set; }

        public virtual IEnumerable<TgConnection> Connections { get; set; }

        public TgBot() : base()
        {
            Connections = new HashSet<TgConnection>();
        }
    }
}
