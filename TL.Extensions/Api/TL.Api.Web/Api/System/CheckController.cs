using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;

namespace TL.Api.Web.Api.System
{
    public class CheckController : _SystemApiController
    {
        public CheckController(IStorage storage) : base(storage)
        {
        }

        public override string Command => "system.Check";

        public override string Description => "Используйте этот метод, чтобы проверить основные REST методы";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(string))]
        public IActionResult Get() => this.JsonResponse(ok: true, result: "Check HTTP GET");

        [ApiHttpGet("{id}", UsageDescription = "Этот метод требует указать Id как часть запроса", UsageSample = "/42", ReturnableType = typeof(string))]
        public IActionResult Get(int id) => this.JsonResponse(ok: true, result: new { report = $"Check HTTP GET whith Id = {id}" });

        [ApiHttpPost(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(string))]
        public IActionResult Post([FromQuery] string data) => this.JsonResponse(ok: true, result: new { report = $"Check HTTP POST", data });

        [ApiHttpPost("{id}", UsageDescription = "Этот метод требует указать Id как часть запроса, а Data как параметр", UsageSample = "/42?data=forty two", ReturnableType = typeof(string))]
        public IActionResult Post(int id, [FromQuery] string data) => this.JsonResponse(ok: true, result: new { report = $"Check HTTP POST whith Id = {id}", data });

        [ApiHttpPut(UsageDescription = "Этот метод требует указать Data как параметр", UsageSample = "?data=forty two", ReturnableType = typeof(string))]
        public IActionResult Put([FromQuery] string data) => this.JsonResponse(ok: true, result: new { report = $"Check HTTP PUT", data });

        [ApiHttpPut("{id}", UsageDescription = "Этот метод требует указать Id как часть запроса, а Data как параметр", UsageSample = "/42?data=forty two", ReturnableType = typeof(string))]
        public IActionResult Put(int id, [FromQuery] string data) => this.JsonResponse(ok: true, result: new { report = $"Check HTTP PUT whith Id = {id}", data });

        [ApiHttpDelete(UsageDescription = "Этот метод требует указать Id как параметр.", UsageSample = "?id=42", ReturnableType = typeof(string))]
        public IActionResult Delete([FromQuery] string id) => this.JsonResponse(ok: true, result: new { report = $"Check HTTP DELETE whith Id = {id}" });

        [ApiHttpDelete("{id}", UsageDescription = "Этот метод требует указать Id как часть запроса.", UsageSample = "/42", ReturnableType = typeof(string))]
        public IActionResult Delete(int id) => this.JsonResponse(ok: true, result: new { report = $"Check HTTP DELETE whith Id = {id}"});
    }
}
