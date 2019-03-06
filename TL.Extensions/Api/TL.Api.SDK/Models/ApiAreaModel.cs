using Newtonsoft.Json;
using System.Collections.Generic;
using TL.Api.SDK.Objects;

namespace TL.Api.SDK.Models
{
    public class ApiAreaModel : JsonApiObject
    {
        protected override string _Description => "Модель области контроллеров API";

        [JsonProperty(Order = 0)]
        public string Name { get; set; }

        [JsonProperty(Order = 1)]
        public IList<ApiMethodModel> Methods { get; set; }
    }
}
