using Microsoft.AspNetCore.Http;
using System;
using TL.Api.SDK.Models;

namespace TL.Api.SDK.Services.ApiDocumentation
{
    public interface IApiDocumentationService
    {
        DateTime UAD();

        ApiDocumentationModel GetDocumentation();

        ApiDocumentationModel GetDocumentation(HostString host);
    }
}
