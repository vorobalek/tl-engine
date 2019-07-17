using System;
using TL.Engine.SDK.Entities;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgUserRole : EntityComparableStored<(Guid, Guid)>
    {
        public override (Guid, Guid) Id { get => (UserId, RoleId); set => (UserId, RoleId) = value; }

        public Guid UserId { get; set; }

        public virtual TgUser User { get; set; }

        public Guid RoleId { get; set; }

        public virtual TgRole Role { get; set; }
    }
}
