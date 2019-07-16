using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    /// <summary>
    /// Интерфейс менеджера элементарных сущностей <typeparamref name="TEntity"/> с первичным ключом, отслеживающих отметки времени создания и последнего изменения.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа сущности.</typeparam>
    public interface IEntityComparableManager<TEntity, TKey> : IEntityManager<TEntity>
        where TEntity : class, IEntityComparable<TKey>
        where TKey : IComparable
    {
        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity"/> по первичному <typeparamref name="TKey"/> ключу
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        TEntity Get(TKey key);

        /// <summary>
        /// Получить все экземпляры сущности типа <typeparamref name="TEntity"/> по первичному <typeparamref name="TKey"/> ключу
        /// </summary>
        /// <param name="keys">Значения первичного ключа.</param>
        /// <returns>
        /// Экземпляры отслеживаемой сущности.
        /// </returns>
        IEnumerable<TEntity> GetAll(params TKey[] keys);

        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey"/> ключу или создать новый в хранилище.
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        TEntity GetOrCreate(TKey key, bool loadDeleted = false, TEntity entity = null, bool cacheOnly = false);

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity" /> или создать новый в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        TEntity UpdateOrCreate(TEntity entity, bool cacheOnly = false);

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity" />, удовлетворяющей предикату или создать новый в хранилище.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        TEntity UpdateOrCreate(Func<TEntity, bool> predicate, TEntity entity = null, bool cacheOnly = false);

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey"/> ключу или создать новый в хранилище.
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        TEntity UpdateOrCreate(TKey key, TEntity entity = null, bool cacheOnly = false);
    }
}
