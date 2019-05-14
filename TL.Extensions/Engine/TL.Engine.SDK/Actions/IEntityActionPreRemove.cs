using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    public interface IEntityActionPreRemove<TEntity> : IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
    }
}
