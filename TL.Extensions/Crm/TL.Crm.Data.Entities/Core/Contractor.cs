using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Contractor : EntityComparableStored<Guid>
    {
        public virtual IEnumerable<Lead> Leads { get; set; }

        public Contractor()
        {
            Leads = new HashSet<Lead>();
        }
    }
}
