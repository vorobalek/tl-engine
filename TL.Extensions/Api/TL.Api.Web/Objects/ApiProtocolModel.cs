using Newtonsoft.Json;
using System;
using TL.Api.Web.Objects.SDK;

namespace TL.Api.Web.Objects
{
    public class ApiProtocolModel : __BaseApiObject__
    {
        protected override string ObjectDescription => "Модель протокола API";

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
