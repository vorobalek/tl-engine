using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    /// <summary>
    /// <see cref="IEntityAction{TEntity}"/>, проверяет, что сущность типа <typeparamref name="TEntity"/> может быть сохранена.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <seealso cref="IEntityAction{TEntity}" />
    public interface IEntityActionCanSave<TEntity> : IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
    }
}
