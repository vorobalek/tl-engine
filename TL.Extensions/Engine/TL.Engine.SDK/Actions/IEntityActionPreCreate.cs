using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    public interface IEntityActionPreCreate<TEntity> : IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
    }
}
