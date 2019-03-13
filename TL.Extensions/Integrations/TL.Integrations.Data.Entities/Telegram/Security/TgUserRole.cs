using System;
using TL.Engine.SDK.Entities;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgUserRole : EntityStored
    {
        public Guid UserId { get; set; }

        public virtual TgUser User { get; set; }

        public Guid RoleId { get; set; }

        public virtual TgRole Role { get; set; }
    }
}
