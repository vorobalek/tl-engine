using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TL.Api.Web.Objects.SDK;

namespace TL.Api.Web.Objects
{
    public class ApiAreaModel : __BaseApiObject__
    {
        protected override string ObjectDescription => "Модель области контроллеров API";

        [JsonProperty(Order = 0)]
        public string Name { get; set; }

        [JsonProperty(Order = 1)]
        public IList<ApiMethodModel> Methods { get; set; }
    }
}
