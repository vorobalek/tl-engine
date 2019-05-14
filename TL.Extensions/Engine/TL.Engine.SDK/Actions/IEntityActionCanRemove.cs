using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    public interface IEntityActionCanRemove<TEntity> : IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
    }
}
