using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Services;

namespace TL.Engine.SDK.Managers
{
    /// <summary>
    /// Абстрактная реализация менеджера элементарных сущностей <typeparamref name="TEntity"/> с первичным ключом, поддерживающих свои дубликаты, отслеживающих отметки времени создания и последнего изменения.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа сущности.</typeparam>
    /// <seealso cref="EntityComparableManager{TEntity, TKey}" />
    /// <seealso cref="IEntityDuplicateManager{TEntity, TKey}" />
    public abstract class EntityDuplicateManager<TEntity, TKey> : EntityComparableManager<TEntity, TKey>, IEntityDuplicateManager<TEntity, TKey>
        where TEntity : class, IEntityDuplicate<TKey>, IEntityComparable<TKey>
        where TKey : struct, IComparable
    {
        public EntityDuplicateManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        /// <summary>
        /// Получить оригинал сущности <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public TEntity GetOriginal(TKey key, bool loadDeleted = false)
        {
            var entity = GetByKey(key);
            if (entity.OriginalId.HasValue)
            {
                return GetOriginal(entity.OriginalId.Value, loadDeleted);
            }
            else
            {
                return entity;
            }
        }

        /// <summary>
        /// Получить оригинал сущности <typeparamref name="TEntity" />, удовлетворяющей предикату
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public TEntity GetOriginal(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            var entity = Get(predicate, loadDeleted);
            if (entity.OriginalId.HasValue)
            {
                return GetOriginal(entity.OriginalId.Value, loadDeleted);
            }
            else
            {
                return entity;
            }
        }
    }
}
