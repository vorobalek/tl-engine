using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Crm.Data.Entities.Periphery;
using TL.Engine.SDK.Entities;

namespace TL.Crm.Data.Entities.Core
{
    public class Lead : EntityDuplicateComparableStored<Guid>
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public Guid? ContractorId { get; set; }

        public virtual Contractor Contractor { get; set; }

        public Guid? InviteId { get; set; }

        public virtual Invite Invite { get; set; }

        public virtual IEnumerable<LeadPhone> Phones { get; set; }

        public Lead() : base()
        {
            Phones = new HashSet<LeadPhone>();
            Duplicates = new HashSet<Lead>();
        }

        public new IEnumerable<Lead> Duplicates { get; set; }

        public static Lead System =>
            new Lead()
            {
                Id = User.System.Id,
                UserId = User.System.Id,
                Firstname = "Автоматика",
                Lastname = "Системы",
                Middlename = "TL Engine",
                ContractorId = Contractor.System.Id
            };
    }
}
