using Newtonsoft.Json;

namespace TL.Engine.SDK.Objects
{
    [JsonObject]
    public abstract class JsonApiObject : BaseApiObject
    {
        [JsonIgnore]
        protected override abstract string _Description { get; }
    }
}
