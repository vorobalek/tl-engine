using ExtCoreEntity = ExtCore.Data.Entities.Abstractions.IEntity;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Интерфейс элементарной сущности, отображаемой в базу данных.
    /// </summary>
    /// <seealso cref="ExtCore.Data.Entities.Abstractions.IEntity" />
    public interface IEntity : ExtCoreEntity
    {
        /// <summary>
        /// Сущность удалена.
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
