using Microsoft.AspNetCore.Http;
using TL.Api.SDK.Models;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Api.SDK.Services.ApiDocumentation
{
    public interface IApiDocumentationService
    {
        [PrivateApi(Description = "Обновить автоматическую API-документацию. Возвращает актуальную документацию.")]
        ApiDocumentationModel Update();

        ApiDocumentationModel Get();

        ApiDocumentationModel Get(HostString host);
    }
}
