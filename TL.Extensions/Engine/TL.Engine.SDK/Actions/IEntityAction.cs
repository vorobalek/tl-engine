using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Actions
{
    /// <summary>
    /// Интерфейс точки расширения для работы над сущностями.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности <see cref="IEntity"/>.</typeparam>
    public interface IEntityAction<TEntity>
        where TEntity : class, IEntity
    {
        /// <summary>
        /// Метод точки расширения.
        /// </summary>
        /// <param name="entity">Ссылка на объект сущности.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns></returns>
        bool Invoke(ref TEntity entity, bool cacheOnly = false);
    }
}
