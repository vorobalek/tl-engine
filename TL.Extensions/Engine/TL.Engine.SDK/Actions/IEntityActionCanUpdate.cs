using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    public interface IEntityActionCanUpdate<TEntity> : IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
    }
}
