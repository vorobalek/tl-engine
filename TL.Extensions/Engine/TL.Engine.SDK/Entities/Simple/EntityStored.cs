using System;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Абстрактная реализация элементарной сущности <see cref="Entity"/>, отслеживающей отметки времени создания и последнего изменения.
    /// </summary>
    /// <seealso cref="Entity" />
    /// <seealso cref="IEntityStored" />
    public abstract class EntityStored : Entity, IEntityStored
    {
        /// <summary>
        /// Отметка времени создания экземпляра сущности.
        /// </summary>
        public virtual DateTime CreationDate { get; set; } = DateTime.Now.ToUniversalTime();

        /// <summary>
        /// Отметка времени последнего изменения экземпляра сущности.
        /// </summary>
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
