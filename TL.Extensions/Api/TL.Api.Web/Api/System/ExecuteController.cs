using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using TL.Api.Data.Entities.Security;
using TL.Api.Data.Managers;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Attributes.Api.Executable;

using TlUser = TL.Engine.Data.Entities.Security.User;

namespace TL.Api.Web.Api.System
{
    public class ExecuteController : _SystemApiController
    {
        IServiceProvider ServiceProvider { get; set; }

        ITokenManager TokenManager { get; set; }

        ITokenLogManager TokenLogManager { get; set; }

        IUserManager UserManager { get; set; }

        public ExecuteController(IServiceProvider serviceProvider, ITokenManager tokenManager, ITokenLogManager tokenLogManager, IUserManager userManager, IStorage storage) : base(storage)
        {
            ServiceProvider = serviceProvider;
            TokenManager = tokenManager;
            TokenLogManager = tokenLogManager;
            UserManager = userManager;
        }

        public override string Command => "system.Execute";

        public override string Description => $"Используйте для выполнения метода API";

        [ApiHttpGet("{method}", UsageDescription = "Этот метод требует указать имя метода как часть запроса", UsageSample = "/TL.Engine.Data.Managers.UserManager:Get?username=system", ReturnableType = typeof(object))]
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

            try
            {
                var result = Exec(existMethod, instance);

                return this.JsonResponse(true, result: result);
            }
            catch
            {
                return this.JsonResponse(false, error_code: StatusCodes.Status500InternalServerError);
            }
        }


        [ApiHttpGet("{token}/{method}", UsageDescription = "Этот метод требует указать токен для выполнения защищенного метогда и имя защищенного метода как часть запроса", UsageSample = "/<TOKEN>/TL.Engine.Data.Managers.UserManager:Create?username=tl-engine_user&password=test&description=Проверка работоспособности API", ReturnableType = typeof(object))]
        public IActionResult Get(string token, string method)
        {
            Token existToken = null;
            TlUser existUser = null;

            if (!Guid.TryParse(token, out Guid guidToken))
            {
                return this.JsonResponse(false, error_code: StatusCodes.Status403Forbidden);
            }
            else
            {
                existToken = TokenManager.Get(guidToken);
                if (existToken == null)
                {
                    return this.JsonResponse(false, error_code: StatusCodes.Status403Forbidden);
                }
            }

            if (!Guid.TryParse(User.Claims.FirstOrDefault(e => e.Type == nameof(TlUser.Id))?.Value ?? "", out Guid userId))
            {
                existUser = UserManager.Get(userId);
            }

            var tokenLog = new TokenLog()
            {
                Id = Guid.NewGuid(),
                Token = existToken,
                TokenId = existToken.Id,
                User = existUser,
                UserId = existUser?.Id,
                Method = method,
                Parameters = HttpContext.Request.QueryString.Value
            };

            var m = method.Split(":");

            if (m.Length != 2)
            {
                tokenLog.StatusCode = StatusCodes.Status400BadRequest;
                TokenLogManager.Create(tokenLog);
                return this.JsonResponse(false, error_code: StatusCodes.Status400BadRequest);
            }

            var type = m[0];
            var func = m[1];

            var existType = ExtensionManager.Assemblies.SelectMany(a => a.GetTypes()).FirstOrDefault(t => t.FullName == type);

            if (existType == null)
            {
                tokenLog.StatusCode = StatusCodes.Status404NotFound;
                TokenLogManager.Create(tokenLog);
                return this.JsonResponse(false, error_code: StatusCodes.Status404NotFound);
            }

            var instance = ActivatorUtilities.CreateInstance(ServiceProvider, existType);

            var existMethod = existType.GetMethods().Where(mt => mt.GetCustomAttributes<PrivateApiAttribute>(true).Count() > 0 && mt.Name == func).FirstOrDefault();

            if (existMethod == null)
            {
                tokenLog.StatusCode = StatusCodes.Status404NotFound;
                TokenLogManager.Create(tokenLog);
                return this.JsonResponse(false, error_code: StatusCodes.Status404NotFound);
            }

            try
            {
                var result = Exec(existMethod, instance);

                tokenLog.StatusCode = StatusCodes.Status200OK;
                TokenLogManager.Create(tokenLog);

                return this.JsonResponse(true, result: result);
            }
            catch
            {
                tokenLog.StatusCode = StatusCodes.Status500InternalServerError;
                TokenLogManager.Create(tokenLog);

                return this.JsonResponse(false, error_code: StatusCodes.Status500InternalServerError);
            }
        }

        private object Exec(MethodInfo methodInfo, object instance)
        {
            var listArgs = new List<object>();
            foreach (var parameter in methodInfo.GetParameters())
            {
                var stringValue = HttpUtility.ParseQueryString(HttpContext.Request.QueryString.Value).Get(parameter.Name);
                if (!string.IsNullOrWhiteSpace(stringValue))
                {
                    listArgs.Add(TypeDescriptor.GetConverter(parameter.ParameterType).ConvertFromInvariantString(stringValue));
                }
                else
                {
                    listArgs.Add(null);
                }
            }
            var args = listArgs.ToArray();
            return methodInfo.Invoke(instance, args);
        }
    }
}
