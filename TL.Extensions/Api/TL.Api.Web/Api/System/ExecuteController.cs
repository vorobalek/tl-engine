using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using System.Web;
using TL.Api.SDK.Attributes.Executable;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;

namespace TL.Api.Web.Api.System
{
    public class ExecuteController : _SystemApiController
    {
        public IServiceProvider ServiceProvider { get; set; }

        public ExecuteController(IServiceProvider serviceProvider, IStorage storage) : base(storage)
        {
            ServiceProvider = serviceProvider;
        }

        public override string Command => "system.Execute";

        public override string Description => $"Используйте для выполнения метода API";

        [ApiHttpGet("{method}", UsageDescription = "Этот метод требует указать имя метода как часть запроса", UsageSample = "/test", ReturnableType = typeof(object))]
        public IActionResult Get(string method)
        {
            var m = method.Split(":");

            if (m.Length != 2)
            {
                return this.JsonResponse(false, error_code: StatusCodes.Status400BadRequest);
            }

            var type = m[0];
            var func = m[1];

            var existType = ExtensionManager.Assemblies.SelectMany(a => a.GetTypes()).FirstOrDefault(t => t.FullName == type);

            if (existType == null)
            {
                return this.JsonResponse(false, error_code: StatusCodes.Status404NotFound);
            }

            var instance = ActivatorUtilities.CreateInstance(ServiceProvider, existType);

            var existMethod = existType.GetMethods().Where(mt => mt.GetCustomAttributes<PublicApiAttribute>().Count() > 0 && mt.Name == func).FirstOrDefault();

            if (existMethod == null)
            {
                return this.JsonResponse(false, error_code: StatusCodes.Status404NotFound);
            }

            var args = existMethod.GetParameters().Select(p => HttpUtility.ParseQueryString(HttpContext.Request.QueryString.Value).Get(p.Name)).ToArray();
            
            return this.JsonResponse(true, result: existMethod.Invoke(instance, args));
        }
    }
}
