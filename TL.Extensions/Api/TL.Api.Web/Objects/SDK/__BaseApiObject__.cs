using Newtonsoft.Json;

namespace TL.Api.Web.Objects.SDK
{
    [JsonObject]
    public abstract class __BaseApiObject__ : __IBaseApiObject__
    {
        [JsonIgnore]
        protected abstract string ObjectDescription { get; }

        public virtual string GetObjectDescription() => ObjectDescription;
    }
}
