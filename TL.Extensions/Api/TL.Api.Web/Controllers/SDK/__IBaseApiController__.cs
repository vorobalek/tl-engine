using TL.Api.Web.Formats;

namespace TL.Api.Web.Controllers.SDK
{
    public interface __IBaseApiController__
    {
        string Area { get; }

        string Command { get; }

        string Description { get; }

        JsonApiResponseFormat GetJson(bool ok, object result, int? error_code, string description);
    }
}
