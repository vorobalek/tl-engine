using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;

namespace TL.Api.Web.Api.System
{
    public class PingController : _SystemApiController
    {
        public PingController(IStorage storage) : base(storage)
        {
        }

        public override string Command => "system.Ping";

        public override string Description => "Используйте для проверки скорости отклика сервера.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(TimeSpan))]
        public IActionResult Get() => this.JsonResponse(true);
    }
}
