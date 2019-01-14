namespace TL.Engine.SDK.Attributes.Http
{
    public class ApiHttpPutAttribute : ApiHttpMethodAttribute
    {
        public ApiHttpPutAttribute()
            : base(new string[] { "PUT" }, "")
        {
        }

        public ApiHttpPutAttribute(string template)
            : base(new string[] { "PUT" }, template)
        {
        }
    }
}
