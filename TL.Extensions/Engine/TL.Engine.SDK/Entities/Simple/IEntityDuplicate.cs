using System;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Интерфейс элементарной сущности <see cref="IEntityComparable{TKey}"/>, поддерживающей свои дубликаты.
    /// </summary>
    /// <typeparam name="TKey">Тип первичного ключа сущности.</typeparam>
    /// <seealso cref="IEntityComparable{TKey}" />
    public interface IEntityDuplicate<TKey> : IEntityComparable<TKey>
        where TKey : struct, IComparable
    {
        /// <summary>
        /// Внешний ключ на оригинал.
        /// </summary>
        TKey? OriginalId { get; set; }
    }
}
