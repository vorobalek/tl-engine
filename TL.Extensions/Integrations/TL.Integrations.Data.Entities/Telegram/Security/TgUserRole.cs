using ExtCore.Data.Entities.Abstractions;
using System;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgUserRole : IEntity
    {
        public Guid UserId { get; set; }

        public virtual TgUser User { get; set; }

        public Guid RoleId { get; set; }

        public virtual TgRole Role { get; set; }
    }
}
