using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    /// <summary>
    /// Интерфейс менеджера элементарных сущностей <typeparamref name="TEntity"/> с первичным ключом, поддерживающих свои дубликаты, отслеживающих отметки времени создания и последнего изменения.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа сущности.</typeparam>
    /// <seealso cref="IEntityComparableManager{TEntity, TKey}" />
    public interface IEntityDuplicateManager<TEntity, TKey> : IEntityComparableManager<TEntity, TKey>
        where TEntity : class, IEntityDuplicate<TKey>, IEntityComparable<TKey>
        where TKey : struct, IComparable
    {
        /// <summary>
        /// Получить оригинал сущности <typeparamref name="TEntity"/> по первичному <typeparamref name="TKey"/> ключу
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity GetOriginal(TKey key, bool loadDeleted = false);

        /// <summary>
        /// Получить оригинал сущности <typeparamref name="TEntity"/>, удовлетворяющей предикату
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Экземпляр отслеживаемой сущности.</returns>
        TEntity GetOriginal(Func<TEntity, bool> predicate, bool loadDeleted = false);
    }
}
