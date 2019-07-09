namespace TL.Engine.SDK.Objects
{
    /// <summary>
    /// Интерфейс базового сериализованного объекта
    /// </summary>
    public interface IBaseObject
    {
        /// <summary>
        /// Получить описание базового сериализованного объекта
        /// </summary>
        /// <returns>Описание базового сериализованного объекта</returns>
        string GetDescription();
    }
}
