using System;
using System.Linq;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public abstract class EntityComparableStoredRepository<TEntity, TKey> : EntityRepository<TEntity>, IEntityComparableStoredRepository<TEntity, TKey>
        where TEntity : EntityComparableStored<TKey>
        where TKey : IComparable
    {
        public TEntity GetById(TKey key)
        {
            return Load(dbSet.SingleOrDefault(e => e.Id.Equals(key)));
        }
    }
}
