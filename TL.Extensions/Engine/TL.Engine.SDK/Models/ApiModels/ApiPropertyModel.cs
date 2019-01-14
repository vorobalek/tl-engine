using Newtonsoft.Json;
using TL.Engine.SDK.Objects;

namespace TL.Engine.SDK.Models
{
    public class ApiPropertyModel : JsonApiObject
    {
        protected override string _Description => "Модель свойства объекта API";

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Type { get; set; }
    }
}
