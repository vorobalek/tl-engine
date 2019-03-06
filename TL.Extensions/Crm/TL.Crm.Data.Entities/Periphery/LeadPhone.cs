using System;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Periphery
{
    public class LeadPhone : EntityComparableStored<Guid>
    {
        public Guid LeadId { get; set; }

        public virtual Lead Lead { get; set; }

        public string PhoneNumber { get; set; }
    }
}
