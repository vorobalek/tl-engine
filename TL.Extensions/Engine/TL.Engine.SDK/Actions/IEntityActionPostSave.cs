using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    /// <summary>
    /// <see cref="IEntityAction{TEntity}"/>, выполняется после сохранения сущности типа <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <seealso cref="IEntityAction{TEntity}" />
    public interface IEntityActionPostSave<TEntity> : IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
    }
}
