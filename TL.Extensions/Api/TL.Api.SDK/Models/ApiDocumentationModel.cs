using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TL.Api.SDK.Objects;

namespace TL.Api.SDK.Models
{
    public class ApiDocumentationModel : JsonApiObject
    { 
        protected override string _Description => "Объект автоматической API документации";

        public ApiDocumentationModel()
        {
        }

        public ApiDocumentationModel(HostString host)
        {
            Host = host;
        }

        public IList<ApiObjectModel> GetObjects() => Objects;

        public IList<ApiMethodModel> GetMethods() => Methods;

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
        public static TimeSpan CreationTime { get; set; }

        [JsonProperty(Order = 5)]
        public static DateTime LastUpdate { get; set; }
    }
}
