using System;
using TL.Engine.SDK.Entities;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.Entities.Telegram.Relationships
{
    public class TgConnection : EntityComparableStored<(Guid, Guid)>
    {
        public Guid BotId { get; set; }

        public virtual TgBot Bot { get; set; }

        public Guid UserId { get; set; }

        public virtual TgUser User { get; set; }

        public TgConnection() : base()
        {
        }
    }
}
