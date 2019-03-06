using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Contractor : EntityComparableStored<Guid>
    {
        public Guid? OriginalId { get; set; }

        public virtual Contractor Original { get; set; }

        public virtual IEnumerable<Contractor> Dublicates { get; set; }

        public virtual IEnumerable<Lead> Leads { get; set; }

        public virtual IEnumerable<Invite> Invites { get; set; }

        public Contractor()
        {
            Leads = new HashSet<Lead>();
            Invites = new HashSet<Invite>();
            Dublicates = new HashSet<Contractor>();
        }

        public static Contractor System =>
            new Contractor()
            {
                Id = User.System.Id,
            };
    }
}
