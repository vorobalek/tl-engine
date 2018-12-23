using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TL.Api.Web.Objects.SDK;

namespace TL.Api.Web.Objects
{
    public class ApiPropertyModel : __BaseApiObject__
    {
        protected override string ObjectDescription => "Модель свойства объекта API";

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Type { get; set; }
    }
}
