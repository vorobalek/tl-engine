using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Attributes.Http;
using TL.Engine.SDK.Controllers;
using TL.Engine.SDK.Models;
using TL.Engine.SDK.Objects;

namespace TL.Engine.SDK.Services.ApiDocumentation
{
    public class ApiDocumentationService : IApiDocumentationService
    {
        public IServiceProvider ServiceProvider { get; }

        public ApiDocumentationService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public ApiDocumentationModel GetDocumentation()
        {
            if (!ApiDocumentationModel.IsRelevant)
            {
                InitializeDocumentation();
            }
            return new ApiDocumentationModel();
        }

        public ApiDocumentationModel GetDocumentation(HostString host)
        {
            if (!ApiDocumentationModel.IsRelevant)
            {
                InitializeDocumentation();
            }
            return new ApiDocumentationModel(host);
        }

        private void InitializeDocumentation()
        {
            var timeStrat = DateTime.Now;
            InitializeMethods();
            InitializeObjects();
            ApiDocumentationModel.LastUpdate = DateTime.Now;
            ApiDocumentationModel.IsRelevant = true;
            ApiDocumentationModel.CreationTime = DateTime.Now - timeStrat;
        }

        private void InitializeMethods()
        {
            var typeApiHttpMethodAttribute = typeof(ApiHttpMethodAttribute);
            ApiDocumentationModel.Methods = ExtensionManager.GetImplementations<IBaseApiController>()
                .Where(type => !type.IsAbstract && !type.IsInterface)
                .Select(type => ActivatorUtilities.CreateInstance(ServiceProvider, type) as IBaseApiController)
                .Select(controller =>
                {
                    return new ApiMethodModel()
                    {
                        Command = controller.Command,
                        Area = controller.Area,
                        Description = controller.Description,
                        Protocols = controller
                            .GetType()
                            .GetMethods()
                            .SelectMany(method => method.GetCustomAttributes(typeApiHttpMethodAttribute, true))
                            .Distinct()
                            .Select(protocol =>
                            {
                                var apiprotocol = protocol as ApiHttpMethodAttribute;
                                return new ApiProtocolModel()
                                {
                                    Name = apiprotocol.HttpMethods.FirstOrDefault(),
                                    Description = apiprotocol.UsageDescription,
                                    ReturnableType = GetGenericTypeFullName(apiprotocol?.ReturnableType),
                                    Sample = $"{controller.Command}{apiprotocol.UsageSample}"
                                };
                            })
                            .ToList()
                    };
                })
                .ToList();
        }

        private void InitializeObjects()
        {
            ApiDocumentationModel.Objects = ExtensionManager.GetInstances<IBaseApiObject>()
                .Select(obj =>
                {
                    var type = obj.GetType();
                    return new ApiObjectModel()
                    {
                        Name = type.Name,
                        Description = obj.GetDescription(),
                        Properties = type.GetProperties()
                            .Select(prop =>
                            {
                                return new ApiPropertyModel()
                                {
                                    Name = prop.Name,
                                    Type = GetGenericTypeFullName(prop.PropertyType)
                                };
                            })
                            .ToList()
                    };
                })
                .ToList();
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
    }
}
