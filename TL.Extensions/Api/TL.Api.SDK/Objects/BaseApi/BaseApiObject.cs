using TL.Engine.SDK.Objects;

namespace TL.Api.SDK.Objects
{
    /// <summary>
    /// Абстрактная реализация базового сериализованного объекта API документации
    /// </summary>
    /// <seealso cref="BaseObject" />
    /// <seealso cref="IBaseApiObject" />
    public abstract class BaseApiObject : BaseObject, IBaseApiObject
    {
    }
}
