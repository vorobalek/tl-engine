using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TL.Api.Web.Attributes.Http.SDK;
using TL.Api.Web.Controllers.SDK;
using TL.Api.Web.Objects;
using TL.Api.Web.Objects.SDK;

namespace TL.Api.Web.Services
{
    public class ApiDocumentationService : IApiDocumentationService
    {
        public ApiDocumentationService()
        {
        }

        public void SetHost(HostString host)
        {
            ApiDocumentation.Host = host;
        }

        public ApiDocumentation GetDocumentation(HostString host)
        {
            SetHost(host);
            return GetDocumentation();
        }

        public void CheckDocumentation()
        {
            if (!ApiDocumentation.IsRelevant)
            {
                InitializeDocumentation();
            }
        }

        public ApiDocumentation GetDocumentation()
        {
            CheckDocumentation();
            return new ApiDocumentation();
        }

        private void InitializeDocumentation()
        {
            InitializeMethods();
            InitializeObjects();
            ApiDocumentation.LastUpdate = DateTime.Now;
            ApiDocumentation.IsRelevant = true;
        }

        private void InitializeObjects()
        {
            ApiDocumentation.Objects = new List<ApiObjectModel>();

            var baseType = typeof(__IBaseApiObject__);
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var typeJsonPropertyAttribute = typeof(JsonPropertyAttribute);

            foreach (var type in types)
            {
                if (type.IsAbstract || type.IsInterface) continue;
                if (type.GetInterfaces().Contains(baseType)
                    && Activator.CreateInstance(type) is __IBaseApiObject__ obj)
                {
                    var apiObject = new ApiObjectModel()
                    {
                        Name = type.Name,
                        Description = obj.GetObjectDescription(),
                        Properties = new List<ApiPropertyModel>()
                    };

                    foreach (var property in type.GetProperties())
                    {
                        apiObject.Properties.Add(new ApiPropertyModel()
                        {
                            Name = property.Name,
                            Type = GetGenericTypeFullName(property.PropertyType)
                        });
                    }

                    ApiDocumentation.Objects.Add(apiObject);
                }
            }
        }

        private string GetGenericTypeFullName(Type type)
        {
            if (type?.IsGenericType ?? false)
            {
                var genericTypesNames = new List<string>();
                foreach (var item in type.GenericTypeArguments)
                {
                    genericTypesNames.Add(GetGenericTypeFullName(item));
                }

                return $"{type.Name.Split('`')[0]}<{string.Join(", ", genericTypesNames)}>";
            }

            return type?.Name;
        }

        private void InitializeMethods()
        {
            ApiDocumentation.Methods = new List<ApiMethodModel>();

            var baseType = typeof(__IBaseApiController__);
            var apiControllers = new List<__IBaseApiController__>();
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var httpMethodAttributeType = typeof(ApiHttpMethodAttribute);

            foreach (var type in types)
            {
                if (type.IsAbstract || type.IsInterface) continue;
                if (type.GetInterfaces().Contains(baseType)
                    && Activator.CreateInstance(type) is __IBaseApiController__ controller)
                {

                    var protocols = controller
                        .GetType()
                        .GetMethods()
                        .SelectMany(method => method.GetCustomAttributes(httpMethodAttributeType, true))
                        .Distinct();

                    var methodModel = new ApiMethodModel()
                    {
                        Command = controller.Command,
                        Area = controller.Area,
                        Description = controller.Description,
                        Protocols = new List<ApiProtocolModel>()
                    };

                    foreach (ApiHttpMethodAttribute protocol in protocols)
                    {
                        methodModel.Protocols.Add(new ApiProtocolModel()
                        {
                            Name = protocol.HttpMethods.FirstOrDefault(),
                            Description = protocol.UsageDescription,
                            ReturnableType = GetGenericTypeFullName(protocol?.ReturnableType),
                            Sample = $"{controller.Command}{protocol.UsageSample}"
                        });
                    }

                    ApiDocumentation.Methods.Add(methodModel);
                }
            }
        }
    }
}
