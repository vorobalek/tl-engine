using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.TelegramBots.Web.Areas.TelegramBots.Controllers
{
    [Area("TelegramBots")]
    [Authorize(Roles = "sa")]
    public abstract class __TelegramBotsController__ : BaseController
    {
        public __TelegramBotsController__(IStorage storage) : base(storage)
        {
        }
    }
}
