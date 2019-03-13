using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Invite : EntityComparableStored<Guid>
    {
        public int MaxMembersCount { get; set; } = 1;

        public DateTime TimeOut { get; set; } = DateTime.MaxValue;

        public bool IsActivated { get; set; } = false;

        public Guid ReferrerId { get; set; } = Contractor.System.Id;

        public virtual Contractor Referrer { get; set; }

        public virtual IEnumerable<Lead> Referrals { get; set; }

        public Invite()
        {
            Referrals = new HashSet<Lead>();
        }
    }
}
