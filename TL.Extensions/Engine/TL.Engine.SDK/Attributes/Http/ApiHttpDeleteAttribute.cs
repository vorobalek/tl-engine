namespace TL.Engine.SDK.Attributes.Http
{
    public class ApiHttpDeleteAttribute : ApiHttpMethodAttribute
    {
        public ApiHttpDeleteAttribute()
            : base(new string[] { "DELETE" }, "")
        {
        }

        public ApiHttpDeleteAttribute(string template)
            : base(new string[] { "DELETE" }, template)
        {
        }
    }
}
