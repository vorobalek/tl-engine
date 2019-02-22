using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public interface IEntityComparableDuplicateStoredManager<TEntity, TKey> : IEntityComparableStoredManager<TEntity, TKey>
        where TEntity : EntityComparableDuplicateStored<TKey>
        where TKey : IComparable
    {
        TEntity GetOriginal(TKey key);
        TEntity GetOriginal(Func<TEntity, bool> predicate);
    }
}
