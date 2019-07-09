using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    /// <summary>
    /// Интерфейс репозитория элементарных сущностей <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <seealso cref="IRepository" />
    public interface IEntityRepository<TEntity> : IRepository
        where TEntity : class, IEntity
    {
        /// <summary>
        /// Добавить в хранилище сущность <typeparamref name="TEntity"/>.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Add(TEntity entity);

        /// <summary>
        /// Уничтожить экземпляр сущности типа <typeparamref name="TEntity"/> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Remove(TEntity entity);

        /// <summary>
        /// Уничтожить экземпляр сущности типа <typeparamref name="TEntity"/>, удовлетворяющей предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Remove(Func<TEntity, bool> predicate, bool loadDeleted = false);

        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity"/>, удовлетворяющей предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Get(Func<TEntity, bool> predicate, bool loadDeleted = false);

        /// <summary>
        /// Получить все сущности типа <typeparamref name="TEntity"/>.
        /// </summary>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        IEnumerable<TEntity> GetAll(bool loadDeleted = false);

        /// <summary>
        /// Получить все сущности типа <typeparamref name="TEntity"/>, удовлетворяющие предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate, bool loadDeleted = false);

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity"/> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Получить и отслеживать сущность из хранилища.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Load(TEntity entity);
    }
}
