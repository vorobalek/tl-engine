using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Crm.Data.Entities.Periphery;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Lead : EntityComparableStored<Guid>
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public Guid? ContractorId { get; set; }

        public virtual Contractor Contractor { get; set; }

        public virtual IEnumerable<LeadPhone> Phones { get; set; }

        public Guid? OriginalId { get; set; }

        public Lead Original { get; set; }

        public IEnumerable<Lead> Dublicates { get; set; }

        public Lead() : base()
        {
            Phones = new HashSet<LeadPhone>();
            Dublicates = new HashSet<Lead>();
        }
    }
}
