using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Controllers;
using TL.Api.SDK.Models;
using TL.Api.SDK.Objects;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Extensions;

namespace TL.Api.SDK.Services.ApiDocumentation
{
    public class ApiDocumentationService : IApiDocumentationService
    {
        public IServiceProvider ServiceProvider { get; }

        private static bool IsRelevant { get; set; }

        private static HostString Host { get; set; }

        private static IList<ApiObjectModel> Objects { get; set; } = new List<ApiObjectModel>();

        private static IList<ApiMethodModel> Methods { get; set; } = new List<ApiMethodModel>();

        private static IList<ApiFunctionModel> Functions { get; set; } = new List<ApiFunctionModel>();

        private static TimeSpan CreationTime { get; set; }

        private static DateTime LastUpdate { get; set; }

        public ApiDocumentationService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public ApiDocumentationModel GetDocumentation()
        {
            if (!IsRelevant)
            {
                InitializeDocumentation();
            }
            return new ApiDocumentationModel()
            {
                IsRelevant = IsRelevant,
                Host = Host,
                Objects = Objects,
                Methods = Methods,
                Functions = Functions,
                CreationTime = CreationTime,
                LastUpdate = LastUpdate,
            };
        }

        public ApiDocumentationModel GetDocumentation(HostString host)
        {
            if (!IsRelevant)
            {
                InitializeDocumentation();
            }
            Host = host;

            var documentation = GetDocumentation();
            documentation.Host = Host;

            return documentation;
        }

        private void InitializeDocumentation()
        {
            var timeStrat = DateTime.Now;
            IsRelevant = false;

            InitializeMethods();
            InitializeObjects();
            InitializeFunctions();

            LastUpdate = DateTime.Now;
            IsRelevant = true;
            CreationTime = DateTime.Now - timeStrat;
        }

        private void InitializeMethods()
        {
            var typeApiHttpMethodAttribute = typeof(ApiHttpMethodAttribute);
            Methods = ExtensionManager.GetImplementations<IBaseApiController>()
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
                                    ReturnableType = apiprotocol?.ReturnableType.GetName(),
                                    Sample = $"{controller.Command}{apiprotocol.UsageSample}"
                                };
                            })
                            .ToList()
                    };
                })
                .OrderBy(m => m.Command)
                .ToList();
        }

        private void InitializeObjects()
        {
            Objects = ExtensionManager.GetInstances<IBaseApiObject>()
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
                                    Type = prop.PropertyType.GetName()
                                };
                            })
                            .ToList()
                    };
                })
                .OrderBy(o => o.Name)
                .ToList();
        }

        private void InitializeFunctions()
        {
            var typePublicApiAttribute = typeof(PublicApiAttribute);
            var typePrivateApiAttribute = typeof(PrivateApiAttribute);
            Functions = ExtensionManager.Assemblies
                .SelectMany(a => a.GetTypes())
                .Where(t => !t.IsInterface && !t.IsAbstract)
                .SelectMany(t => t.GetMethods())
                .Where(m => m.GetCustomAttributes(typePrivateApiAttribute, true).Length > 0)
                .Select(m =>
                {
                    return new ApiFunctionModel()
                    {
                        Namespace = m.ReflectedType.GetFullName(),
                        Name = m.Name,
                        Description = (m.GetCustomAttributes(typePrivateApiAttribute, true).FirstOrDefault() as PrivateApiAttribute).Description,
                        ReturnableType = m.ReturnType.GetName(),
                        Properties = m.GetParameters().Select(p =>
                        {
                            return new ApiPropertyModel()
                            {
                                Type = p.ParameterType.GetName(),
                                Name = p.Name,
                            };
                        }).ToList(),
                        IsPrivate = m.GetCustomAttributes(typePublicApiAttribute, false).Count() > 0 ? false : true
                    };
                })
                .ToList();
        }

        [PublicApi(Description = "Обновить автоматическую API-документацию. Возвращает актуальную документацию.")]
        public ApiDocumentationModel Update()
        {
            InitializeDocumentation();
            return GetDocumentation();
        }
    }
}
