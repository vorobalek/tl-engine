using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public abstract class EntityComparableStoredRepository<TEntity, TKey> : EntityRepository<TEntity>, IEntityComparableStoredRepository<TEntity, TKey>
        where TEntity : class, IEntityComparable<TKey>, IEntityStored
        where TKey : IComparable
    {
        public TEntity Get(TKey key)
        {
            return Get(e => e.Id.Equals(key));
        }
    }
}
