using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public interface IEntityComparableStoredRepository<TEntity, TKey> : IEntityRepository<TEntity>
        where TEntity : EntityComparableStored<TKey>
        where TKey : IComparable
    {
        TEntity Get(TKey key);
    }
}
