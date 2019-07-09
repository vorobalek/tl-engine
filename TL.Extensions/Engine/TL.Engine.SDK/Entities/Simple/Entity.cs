namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Абстрактная реализация элементарной сущности, отображаемой в базу данных.
    /// </summary>
    /// <seealso cref="IEntity" />
    public abstract class Entity : IEntity
    {
        /// <summary>
        /// Сущность удалена.
        /// </summary>
        public virtual bool IsDeleted { get; set; } = false;
    }
}
