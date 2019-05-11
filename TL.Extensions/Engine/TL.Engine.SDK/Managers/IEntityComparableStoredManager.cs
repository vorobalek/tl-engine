using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public interface IEntityComparableStoredManager<TEntity, TKey> : IEntityManager<TEntity>
        where TEntity : class, IEntityComparable<TKey>, IEntityStored
        where TKey : IComparable
    {
        TEntity Get(TKey key, bool loadDeleted = false);
        TEntity GetOrCreate(TKey key, bool loadDeleted = false, TEntity entity = null, bool cacheOnly = false);
        TEntity UpdateOrCreate(TEntity entity, bool cacheOnly = false);
        TEntity UpdateOrCreate(Func<TEntity, bool> predicate, TEntity entity = null, bool cacheOnly = false);
        TEntity UpdateOrCreate(TKey key, TEntity entity = null, bool cacheOnly = false);
    }
}
