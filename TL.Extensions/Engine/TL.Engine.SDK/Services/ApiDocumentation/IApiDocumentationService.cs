using Microsoft.AspNetCore.Http;
using TL.Engine.SDK.Models;

namespace TL.Engine.SDK.Services.ApiDocumentation
{
    public interface IApiDocumentationService
    {
        ApiDocumentationModel GetDocumentation();

        ApiDocumentationModel GetDocumentation(HostString host);
    }
}
