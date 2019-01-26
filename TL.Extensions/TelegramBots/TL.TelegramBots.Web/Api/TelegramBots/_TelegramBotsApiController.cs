using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.TelegramBots.Web.Api.TelegramBots
{
    [Route("api/telegrambots.[controller]")]
    public abstract class _TelegramBotsApiController : BaseApiController
    {
        public _TelegramBotsApiController(IStorage storage) : base(storage)
        {
        }

        public override string Area => "TelegramBots";
    }
}