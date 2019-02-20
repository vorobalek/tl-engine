using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public interface IEntityComparableStoredManager<TEntity, TKey> : IEntityManager<TEntity>
        where TEntity : EntityComparableStored<TKey>
        where TKey : IComparable
    {
        TEntity Get(TKey key);
        TEntity GetOrCreate(TKey key, TEntity entity = null);
        TEntity UpdateOrCreate(TEntity entity);
        TEntity UpdateOrCreate(Func<TEntity, bool> predicate, TEntity entity = null);
        TEntity UpdateOrCreate(TKey key, TEntity entity = null);
    }
}
