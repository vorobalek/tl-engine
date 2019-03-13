using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Contractor : EntityDuplicateComparableStored<Guid>
    {
        public virtual IEnumerable<Lead> Leads { get; set; }

        public virtual IEnumerable<Invite> Invites { get; set; }

        public Contractor()
        {
            Leads = new HashSet<Lead>();
            Invites = new HashSet<Invite>();
            Duplicates = new HashSet<Contractor>();
        }

        public new IEnumerable<Contractor> Duplicates { get; set; }

        public static Contractor System =>
            new Contractor()
            {
                Id = User.System.Id,
            };
    }
}
