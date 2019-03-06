using Newtonsoft.Json;
using TL.Api.SDK.Objects;

namespace TL.Api.SDK.Models
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
