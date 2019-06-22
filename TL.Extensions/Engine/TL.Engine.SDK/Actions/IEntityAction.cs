using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    public interface IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
        bool Invoke(ref TEntity entity, bool cacheOnly = false);
    }
}
