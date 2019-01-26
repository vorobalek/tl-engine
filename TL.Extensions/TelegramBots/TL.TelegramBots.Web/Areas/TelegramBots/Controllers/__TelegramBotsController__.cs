using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.TelegramBots.Web.Areas.TelegramBots.Controllers
{
    [Area("TelegramBots")]
    public abstract class __TelegramBotsController__ : BaseController
    {
        public __TelegramBotsController__(IStorage storage) : base(storage)
        {
        }
    }
}
