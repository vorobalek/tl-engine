using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgRoles
{
    public class TgRoleRepository : EntityRepository<TgRole>, ITgRoleRepository
    {
        public IEnumerable<TgRole> GetAll()
        {
            return dbSet.OrderBy(e => e.Name).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }

        public TgRole GetById(Guid id)
        {
            return Load(dbSet.SingleOrDefault(e => e.Id == id));
        }

        public TgRole GetByName(string name)
        {
            return Load(dbSet.SingleOrDefault(e => e.Name == name));
        }
    }
}
