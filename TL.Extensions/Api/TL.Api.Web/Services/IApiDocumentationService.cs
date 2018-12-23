using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using TL.Api.Web.Objects;

namespace TL.Api.Web.Services
{
    public interface IApiDocumentationService
    {
        ApiDocumentation GetDocumentation();

        ApiDocumentation GetDocumentation(HostString host);
    }
}
