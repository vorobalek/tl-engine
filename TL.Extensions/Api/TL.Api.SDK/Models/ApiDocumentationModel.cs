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

        public IList<ApiFunctionModel> GetFunctions() => Functions;

        [JsonRequired]
        [JsonProperty(Order = 0)]
        public bool IsRelevant { get; set; }

        [JsonProperty(Order = 1)]
        public HostString Host { get; set; }

        [JsonProperty(Order = 2)]
        public IList<ApiObjectModel> Objects { get; set; } = new List<ApiObjectModel>();

        [JsonProperty(Order = 3)]
        public IList<ApiMethodModel> Methods { get; set; } = new List<ApiMethodModel>();

        [JsonProperty(Order = 4)]
        public IList<ApiFunctionModel> Functions { get; set; } = new List<ApiFunctionModel>();

        [JsonProperty(Order = 5)]
        public TimeSpan CreationTime { get; set; }

        [JsonProperty(Order = 6)]
        public DateTime LastUpdate { get; set; }
    }
}
