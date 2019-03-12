using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using TL.Api.SDK.Objects;

namespace TL.Api.SDK.Formats
{
    [JsonObject(ItemReferenceLoopHandling = ReferenceLoopHandling.Ignore)]
    public class JsonApiResponseFormat : JsonApiObject, IBaseApiResponseFormat
    {
        protected override string _Description => "Объект формата JSON ответа";

        [JsonRequired]
        [JsonProperty(Order = 0)]
        public bool Ok { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Order = 1024, ItemReferenceLoopHandling = ReferenceLoopHandling.Ignore)]
        public object Result { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Order = 2048)]
        public int? ErrorCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Order = 4096)]
        public string Description { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Order = int.MaxValue)]
        public TimeSpan? RequestTime { get; set; }

        public JsonApiResponseFormat()
        {
            Ok = false;
            Result = null;
            ErrorCode = StatusCodes.Status404NotFound;
            Description = "Response was not initialized";
            RequestTime = null;
        }

        public JsonApiResponseFormat(bool ok, object result = null, int? error_code = null, string description = null, TimeSpan? request_time = null)
        {
            Ok = ok;
            Result = result;
            ErrorCode = error_code;
            Description = description;
            RequestTime = request_time;
        }
    }
}
