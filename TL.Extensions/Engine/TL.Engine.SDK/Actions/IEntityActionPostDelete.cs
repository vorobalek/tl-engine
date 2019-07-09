using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    /// <summary>
    /// <see cref="IEntityAction{TEntity}"/>, выполняется после удаления сущности типа <typeparamref name="TEntity"/>.
    /// (Удаление сущности означает, что свойство <typeparamref name="TEntity"/>.IsDeleted = <c>true</c>)
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <seealso cref="IEntityAction{TEntity}" />
    public interface IEntityActionPostDelete<TEntity> : IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
    }
}
