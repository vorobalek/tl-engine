using System;
using System.Collections.Generic;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.Abstractions.Core
{
    public interface ILeadRepository : IEntityRepository<Lead>
    {
        IEnumerable<Lead> GetAll();

        Lead GetById(Guid guid);

        Lead GetByUserId(Guid guid);

        Lead Add(Lead lead);

        Lead Update(Lead lead);

        void Delete(Lead lead);
    }
}
