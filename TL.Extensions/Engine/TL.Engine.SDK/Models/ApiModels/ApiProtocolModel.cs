using Newtonsoft.Json;
using TL.Engine.SDK.Objects;

namespace TL.Engine.SDK.Models
{
    public class ApiProtocolModel : JsonApiObject
    {
        protected override string _Description => "Модель протокола API";

        [JsonRequired]
        [JsonProperty(Order = 0)]
        public string Name { get; set; }

        [JsonProperty(Order = 1)]
        public string Description { get; set; }

        [JsonProperty(Order = 2)]
        public string ReturnableType { get; set; }

        [JsonProperty(Order = 3)]
        public string Sample { get; set; }
    }
}
