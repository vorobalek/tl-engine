using Newtonsoft.Json;
using System.Collections.Generic;
using TL.Api.SDK.Objects;

namespace TL.Api.SDK.Models
{
    public class ApiFunctionModel : JsonApiObject
    {
        protected override string _Description => "Модель функции API";

        [JsonRequired]
        [JsonProperty(Order = 0)]
        public string Namespace { get; set; }

        [JsonRequired]
        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(Order = 3)]
        public string ReturnableType { get; set; }

        [JsonProperty(Order = 4)]
        public IList<ApiPropertyModel> Properties { get; set; }

        [JsonProperty(Order = 5)]
        public bool IsPrivate { get; set; }
    }
}
