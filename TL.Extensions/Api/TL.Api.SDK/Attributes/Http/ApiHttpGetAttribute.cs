namespace TL.Api.SDK.Attributes.Http
{
    public class ApiHttpGetAttribute : ApiHttpMethodAttribute
    {
        public ApiHttpGetAttribute()
            : base(new string[] { "GET" }, "")
        {
        }

        public ApiHttpGetAttribute(string template)
            : base(new string[] { "GET" }, template)
        {
        }
    }
}
