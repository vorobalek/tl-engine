using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public interface IEntityComparableStoredRepository<TEntity, TKey> : IEntityRepository<TEntity>
        where TEntity : class, IEntityComparable<TKey>, IEntityStored
        where TKey : IComparable
    {
        TEntity Get(TKey key);
    }
}
