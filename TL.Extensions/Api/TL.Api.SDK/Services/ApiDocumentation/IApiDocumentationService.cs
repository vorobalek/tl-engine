using Microsoft.AspNetCore.Http;
using System;
using TL.Api.SDK.Models;

namespace TL.Api.SDK.Services.ApiDocumentation
{
    public interface IApiDocumentationService
    {
        ApiDocumentationModel Update();

        ApiDocumentationModel GetDocumentation();

        ApiDocumentationModel GetDocumentation(HostString host);
    }
}
