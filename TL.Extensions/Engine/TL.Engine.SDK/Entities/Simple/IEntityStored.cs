using System;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Интерфейс элементарной сущности <see cref="IEntity"/>, отслеживающей отметки времени создания и последнего изменения.
    /// </summary>
    /// <seealso cref="IEntity" />
    public interface IEntityStored : IEntity
    {
        /// <summary>
        /// Отметка времени создания экземпляра сущности.
        /// </summary>
        DateTime CreationDate { get; set; }

        /// <summary>
        /// Отметка времени последнего изменения экземпляра сущности.
        /// </summary>
        DateTime ModifiedDate { get; set; }
    }
}
