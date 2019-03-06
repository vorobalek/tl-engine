using Newtonsoft.Json;

namespace TL.Api.SDK.Objects
{
    [JsonObject]
    public abstract class JsonApiObject : BaseApiObject
    {
        [JsonIgnore]
        protected override abstract string _Description { get; }
    }
}
