using System;
using System.Collections.Generic;
using System.Linq;
using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.EntityFramework.Core.Leads
{
    public class LeadRepository : EntityComparableStoredRepository<Lead, Guid>, ILeadRepository
    {
        public Lead GetByUserId(Guid guid)
        {
            return Load(dbSet.SingleOrDefault(e => e.UserId == guid));
        }
    }
}
