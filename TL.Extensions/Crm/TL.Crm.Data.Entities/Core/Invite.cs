using System;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Invite : EntityComparableStored<Guid>
    {
        public Guid ReferrerId { get; set; }

        public Contractor Referrer { get; set; }

        public Guid? RefferalId { get; set; }

        public Lead Referral { get; set; }

        public bool IsActivated { get; set; }
    }
}
