using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TL.Engine.SDK.Attributes.Http;
using TL.Engine.SDK.Extensions;

namespace TL.Api.Web.Api.System
{
    public class MeController : _SystemApiController
    {
        public MeController(IStorage storage) : base(storage)
        {
        }

        public override string Command => "system.Me";

        public override string Description => "Используйте для получения информации о сервере";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(AssemblyName))]
        public IActionResult Get() => this.JsonResponse(true, Assembly.GetEntryAssembly().GetName());
    }
}
