using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    public interface IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
        bool Invoke(TEntity entity, IServiceProvider serviceProvider);
    }
}
