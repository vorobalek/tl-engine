using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public interface IEntityDuplicateComparableStoredManager<TEntity, TKey> : IEntityComparableStoredManager<TEntity, TKey>
        where TEntity : class, IEntityDuplicate<TKey>, IEntityComparable<TKey>, IEntityStored
        where TKey : struct, IComparable
    {
        TEntity GetOriginal(TKey key);
        TEntity GetOriginal(Func<TEntity, bool> predicate);
    }
}
