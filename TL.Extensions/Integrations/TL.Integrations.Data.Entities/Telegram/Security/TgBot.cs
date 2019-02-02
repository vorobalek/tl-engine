using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using TL.Integrations.Data.Entities.Telegram.Relationships;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgBot : IEntity
    {
        public Guid Id { get; set; }

        public string Token { get; set; }

        public string Username { get; set; }

        public string NativeName { get; set; }

        public string TypeName { get; set; }

        public bool SkipUpdates { get; set; }

        public bool AutoStart { get; set; }

        public bool IsRelevant { get; set; }

        public virtual IEnumerable<TgConnection> Connections { get; set; }

        public TgBot()
        {
            Connections = new HashSet<TgConnection>();
        }
    }
}
