using Newtonsoft.Json;
using System.Collections.Generic;
using TL.Engine.SDK.Objects;

namespace TL.Engine.SDK.Models
{
    public class ApiMethodModel : JsonApiObject
    {
        protected override string _Description => "Модель метода API";

        [JsonRequired]
        [JsonProperty(Order = 0)]
        public string Command { get; set; }

        [JsonProperty(Order = 1)]
        public string Area { get; set; }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(Order = 3)]
        public IList<ApiProtocolModel> Protocols { get; set; }
    }
}
