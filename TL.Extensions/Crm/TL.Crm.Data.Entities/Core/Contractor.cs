using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Contractor : EntityComparableStored<Guid>
    {
        public Guid? OriginalId { get; set; }

        public Contractor Original { get; set; }

        public IEnumerable<Contractor> Dublicates { get; set; }

        public IEnumerable<Lead> Leads { get; set; }

        public IEnumerable<Invite> Invites { get; set; }

        public Contractor()
        {
            Leads = new HashSet<Lead>();
            Invites = new HashSet<Invite>();
            Dublicates = new HashSet<Contractor>();
        }
    }
}
