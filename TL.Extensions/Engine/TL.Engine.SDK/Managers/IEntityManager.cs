using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    /// <summary>
    /// Интерфейс менеджера элементарных сущностей.
    /// </summary>
    public interface IEntityManager
    {
        /// <summary>
        /// Целевой тип.
        /// </summary>
        Type TargetType { get; }

        /// <summary>
        /// Получить все сущности типа <see cref="TargetType"/>
        /// </summary>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        IEnumerable<object> GetAll(bool loadDeleted = false);

        /// <summary>
        /// Получить все сущности типа <see cref="TargetType"/> загруженных из Sql запроса
        /// </summary>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        IEnumerable<object> GetAll(RawSqlString sqlQuery, params object[] parameters);
    }

    /// <summary>
    /// Интерфейс менеджера элементарных сущностей <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    public interface IEntityManager<TEntity> : IEntityManager
        where TEntity : class, IEntity
    {
        /// <summary>
        /// Создать экземпляр сущности типа <typeparamref name="TEntity"/> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Create(TEntity entity, bool cacheOnly = false);

        /// <summary>
        /// Создать экземпляр пустой сущности типа <typeparamref name="TEntity"/> в хранилище.
        /// </summary>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity CreateEmpty(bool cacheOnly = false);

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
        new IEnumerable<TEntity> GetAll(bool loadDeleted = false);

        /// <summary>
        /// Получить все сущности типа <see cref="TEntity"/> загруженных из Sql запроса
        /// </summary>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        new IEnumerable<TEntity> GetAll(RawSqlString sqlQuery, params object[] parameters);

        /// <summary>
        /// Получить все сущности типа <typeparamref name="TEntity"/>, удовлетворяющие предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate, bool loadDeleted = false);

        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity"/>, удовлетворяющей предикату или создать новый в хранилище.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity GetOrCreate(Func<TEntity, bool> predicate, bool loadDeleted = false, TEntity entity = null, bool cacheOnly = false);

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity"/> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Update(TEntity entity, bool cacheOnly = false);

        /// <summary>
        /// Удалить экземпляр сущности типа <typeparamref name="TEntity"/> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Delete(TEntity entity, bool cacheOnly = false);

        /// <summary>
        /// Удалить экземпляр сущности типа <typeparamref name="TEntity"/>, удовлетворяющей предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Delete(Func<TEntity, bool> predicate, bool cacheOnly = false);

        /// <summary>
        /// Удалить все сущности типа <typeparamref name="TEntity"/>, удовлетворяющие предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        IEnumerable<TEntity> DeleteAll(Func<TEntity, bool> predicate, bool cacheOnly = false);

        /// <summary>
        /// Уничтожить экземпляр сущности типа <typeparamref name="TEntity"/> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Remove(TEntity entity, bool cacheOnly = false);

        /// <summary>
        /// Уничтожить экземпляр сущности типа <typeparamref name="TEntity"/>, удовлетворяющей предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Remove(Func<TEntity, bool> predicate, bool loadDeleted = false, bool cacheOnly = false);

        /// <summary>
        /// Уничтожить все сущности типа <typeparamref name="TEntity"/>, удовлетворяющие предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        IEnumerable<TEntity> RemoveAll(Func<TEntity, bool> predicate, bool loadDeleted = false, bool cacheOnly = false);

        /// <summary>
        /// Получить и отслеживать сущность из хранилища.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity Load(TEntity entity);

        /// <summary>
        /// Получить количество сущностей удовлетворяющих предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <returns>Количество подходящих сущностей</returns>
        long Count(Func<TEntity, bool> predicate = null);
    }
}
