using System;
using System.Collections.Generic;
using System.Linq;
using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.EntityFramework.Core.Leads
{
    public class LeadRepository : EntityRepository<Lead>, ILeadRepository
    {
        public Lead Add(Lead lead)
        {
            var addedLead = dbSet.Add(lead);
            return addedLead.Entity;
        }

        public void Delete(Lead lead)
        {
            lead.OriginalId = null;
            dbSet.Remove(lead);
        }

        public IEnumerable<Lead> GetAll()
        {
            return dbSet.OrderBy(e => e.ModifiedDate).Select(e => GetById(e.Id));
        }

        public Lead GetById(Guid guid)
        {
            return Load(dbSet.SingleOrDefault(e => e.Id == guid));
        }

        public Lead GetByUserId(Guid guid)
        {
            return Load(dbSet.SingleOrDefault(e => e.UserId == guid));
        }

        public Lead Update(Lead lead)
        {
            lead.ModifiedDate = DateTime.Now.ToUniversalTime();
            var updatedLead = dbSet.Update(lead);
            return updatedLead.Entity;
        }
    }
}
