using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Engine.SDK.Attributes.Http;
using TL.Engine.SDK.Extensions;

namespace TL.TelegramBots.Web.Api.TelegramBots
{
    public class HelloController : _TelegramBotsApiController
    {
        public HelloController(IStorage storage) : base(storage)
        {
        }

        public override string Command => $"{Area.ToLowerInvariant()}.Hello";

        public override string Description => "Этот метод - демонстрация модульности API системы.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(string))]
        public IActionResult Get() => this.JsonResponse(true, "Hello! There is TelegramBots module!");
    }
}