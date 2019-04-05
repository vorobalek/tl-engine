using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    [Obsolete("В текушей версии не поддерживается. Будет доступно в ближайших релизах.")]
    public interface IEntityActionPostDelete<TEntity> : IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
    }
}
