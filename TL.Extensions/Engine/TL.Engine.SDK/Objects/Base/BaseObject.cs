namespace TL.Engine.SDK.Objects
{
    /// <summary>
    /// Абстрактная реализация базового объекта
    /// </summary>
    /// <seealso cref="IBaseObject" />
    public abstract class BaseObject : IBaseObject
    {
        /// <summary>
        /// Описание базового сериализованного объекта. Не серализуется.
        /// </summary>
        protected abstract string _Description { get; }

        /// <summary>
        /// Получить описание базового сериализованного объекта
        /// </summary>
        /// <returns>
        /// Описание базового сериализованного объекта
        /// </returns>
        public virtual string GetDescription() => _Description;
    }
}
