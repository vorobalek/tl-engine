using Newtonsoft.Json;
using System.Collections.Generic;
using TL.Api.Web.Objects.SDK;

namespace TL.Api.Web.Objects
{
    public class ApiMethodModel : __BaseApiObject__
    {
        protected override string ObjectDescription => "Модель метода API";

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
