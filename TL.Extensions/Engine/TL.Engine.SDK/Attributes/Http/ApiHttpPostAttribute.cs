namespace TL.Engine.SDK.Attributes.Http
{
    public class ApiHttpPostAttribute : ApiHttpMethodAttribute
    {
        public ApiHttpPostAttribute()
            : base(new string[] { "POST" }, "")
        {
        }

        public ApiHttpPostAttribute(string template)
            : base(new string[] { "POST" }, template)
        {
        }
    }
}
