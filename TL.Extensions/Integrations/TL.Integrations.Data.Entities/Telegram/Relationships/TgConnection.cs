using ExtCore.Data.Entities.Abstractions;
using System;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.Entities.Telegram.Relationships
{
    public class TgConnection : IEntity
    {
        public Guid Id { get; set; }

        public Guid BotId { get; set; }

        public virtual TgBot Bot { get; set; }

        public Guid UserId { get; set; }

        public virtual TgUser User { get; set; }
    }
}
