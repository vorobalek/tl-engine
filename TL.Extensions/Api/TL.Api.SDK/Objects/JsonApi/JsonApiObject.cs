using Newtonsoft.Json;

namespace TL.Api.SDK.Objects
{
    /// <summary>
    /// Абстрактная реализация базового сериализованного в Json объекта API документации
    /// </summary>
    /// <seealso cref="BaseApiObject" />
    [JsonObject]
    public abstract class JsonApiObject : BaseApiObject
    {
        /// <summary>
        /// Описание базового сериализованного в Json объекта API документации. Не серализуется.
        /// </summary>
        [JsonIgnore]
        protected override abstract string _Description { get; }
    }
}
