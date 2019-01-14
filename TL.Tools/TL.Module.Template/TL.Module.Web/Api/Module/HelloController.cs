using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Engine.SDK.Attributes.Http;
using TL.Engine.SDK.Extensions;

namespace $safeprojectname$.Api.$saferootprojectname$
{
    public class HelloController : _$saferootprojectname$ApiController
    {
        public HelloController(IStorage storage) : base(storage)
        {
        }

        public override string Command => $"{Area.ToLowerInvariant()}.Hello";

        public override string Description => "Этот метод - демонстрация модульности API системы.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(string))]
        public IActionResult Get() => this.JsonResponse(true, "Hello! There is $saferootprojectname$ module!");
    }
}