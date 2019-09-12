using Microsoft.AspNetCore.Mvc;
using TL.Api.SDK.Controllers;

namespace TL.JustBot.Web.Api.JustBot
{
    [Route("api/justbot.[controller]")]
    public abstract class _JustBotApiController : BaseApiController
    {
        public override string Area => "JustBot";
    }
}
