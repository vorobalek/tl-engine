using Microsoft.AspNetCore.Http;
using TL.Api.SDK.Models;

namespace TL.Api.SDK.Services.ApiDocumentation
{
    public interface IApiDocumentationService
    {
        ApiDocumentationModel Update();

        ApiDocumentationModel Get();

        ApiDocumentationModel Get(HostString host);
    }
}
