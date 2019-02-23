using System;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Invite : EntityComparableStored<Guid>
    {
        public Guid ReferrerId { get; set; }

        public virtual Contractor Referrer { get; set; }

        public Guid? ReferralId { get; set; }

        public virtual Lead Referral { get; set; }

        public bool IsActivated { get; set; }
    }
}
