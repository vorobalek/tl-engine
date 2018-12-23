using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TL.Api.Web.Objects;
using TL.Api.Web.Objects.SDK;

namespace TL.Api.Web.Services
{
    public class ApiDocumentation : __BaseApiObject__
    { 
        protected override string ObjectDescription => "Объект автоматической API документации";

        public ApiDocumentation()
        {
        }

        public ApiDocumentation(HostString host)
        {
            Host = host;
        }

        [JsonRequired]
        [JsonProperty(Order = 0)]
        public static bool IsRelevant { get; set; }

        [JsonProperty(Order = 1)]
        public static HostString Host { get; set; }

        [JsonProperty(Order = 2)]
        public static IList<ApiObjectModel> Objects { get; set; }

        [JsonProperty(Order = 3)]
        public static IList<ApiMethodModel> Methods { get; set; }

        [JsonProperty(Order = 4)]
        public static DateTime LastUpdate { get; set; }
    }
}
