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
            return dbSet.OrderBy(e => e.Name);
        }

        public TgRole GetById(Guid id)
        {
            return dbSet.FirstOrDefault(e => e.Id == id);
        }

        public TgRole GetByName(string name)
        {
            return dbSet.FirstOrDefault(e => e.Name == name);
        }
    }
}
