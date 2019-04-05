using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using TL.Api.Data.Managers;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Api.Web.Api.System
{
    public class ExecuteController : _SystemApiController
    {
        public IServiceProvider ServiceProvider { get; set; }

        public ITokenManager TokenManager { get; set; }

        public ExecuteController(IServiceProvider serviceProvider, ITokenManager tokenManager, IStorage storage) : base(storage)
        {
            ServiceProvider = serviceProvider;
            TokenManager = tokenManager;
        }

        public override string Command => "system.Execute";

        public override string Description => $"Используйте для выполнения метода API";

        [ApiHttpGet("{method}", UsageDescription = "Этот метод требует указать имя метода как часть запроса", UsageSample = "/TL.Account.Data.Managers.UserManager:Get?username=system", ReturnableType = typeof(object))]
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

            var existMethod = existType.GetMethods().Where(mt => mt.GetCustomAttributes<PublicApiAttribute>(true).Count() > 0 && mt.Name == func).FirstOrDefault();

            if (existMethod == null)
            {
                return this.JsonResponse(false, error_code: StatusCodes.Status404NotFound);
            }

            var listArgs = new List<object>();
            foreach (var parameter in existMethod.GetParameters())
            {
                var stringValue = HttpUtility.ParseQueryString(HttpContext.Request.QueryString.Value).Get(parameter.Name);
                if (!string.IsNullOrWhiteSpace(stringValue))
                {
                    listArgs.Add(Convert.ChangeType(stringValue, parameter.ParameterType));
                }
                else
                {
                    listArgs.Add(null);
                }
            }
            var args = listArgs.ToArray();

            return this.JsonResponse(true, result: existMethod.Invoke(instance, args));
        }


        [ApiHttpGet("{token}/{method}", UsageDescription = "Этот метод требует указать токен для выполнения защищенного метогда и имя защищенного метода как часть запроса", UsageSample = "/<TOKEN>/TL.Account.Data.Managers.UserManager:Create?username=tl-engine_user&password=test&description=Проверка работоспособности API", ReturnableType = typeof(object))]
        public IActionResult Get(string token, string method)
        {
            bool f = Guid.TryParse(token, out Guid guidToken);

            if (!f)
            {
                return this.JsonResponse(false, error_code: StatusCodes.Status403Forbidden);
            }
            else
            {
                var existToken = TokenManager.Get(guidToken);
                if (existToken == null)
                {
                    return this.JsonResponse(false, error_code: StatusCodes.Status403Forbidden);
                }
            }

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

            var existMethod = existType.GetMethods().Where(mt => mt.GetCustomAttributes<PrivateApiAttribute>(true).Count() > 0 && mt.Name == func).FirstOrDefault();

            if (existMethod == null)
            {
                return this.JsonResponse(false, error_code: StatusCodes.Status404NotFound);
            }

            var listArgs = new List<object>();
            foreach (var parameter in existMethod.GetParameters())
            {
                var stringValue = HttpUtility.ParseQueryString(HttpContext.Request.QueryString.Value).Get(parameter.Name);
                if (!string.IsNullOrWhiteSpace(stringValue))
                {
                    listArgs.Add(Convert.ChangeType(stringValue, parameter.ParameterType));
                }
                else
                {
                    listArgs.Add(null);
                }
            }
            var args = listArgs.ToArray();

            return this.JsonResponse(true, result: existMethod.Invoke(instance, args));
        }
    }
}
