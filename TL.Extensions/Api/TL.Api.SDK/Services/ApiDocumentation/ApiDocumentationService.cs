using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Controllers;
using TL.Api.SDK.Models;
using TL.Api.SDK.Objects;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Services;

namespace TL.Api.SDK.Services.ApiDocumentation
{
    internal class ApiDocumentationService : IApiDocumentationService
    {
        public IServiceProvider ServiceProvider { get; }

        private bool IsRelevant { get; set; }

        private HostString Host { get; set; }

        private IList<ApiObjectModel> Objects { get; set; } = new List<ApiObjectModel>();

        private IList<ApiMethodModel> Methods { get; set; } = new List<ApiMethodModel>();

        private IList<ApiFunctionModel> Functions { get; set; } = new List<ApiFunctionModel>();

        private TimeSpan CreationTime { get; set; }

        private DateTime LastUpdate { get; set; }

        IActivatorService Activator { get; }

        public ApiDocumentationService(IServiceProvider serviceProvider, IActivatorService activator)
        {
            ServiceProvider = serviceProvider;
            Activator = activator;
        }

        public ApiDocumentationModel Get()
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

        public ApiDocumentationModel Get(HostString host)
        {
            if (!IsRelevant)
            {
                InitializeDocumentation();
            }
            Host = host;

            var documentation = Get();
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
            Methods = Activator.GetInstances<IBaseApiController>()
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
            Objects = Activator.GetInstances<IBaseApiObject>()
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

        public ApiDocumentationModel Update()
        {
            InitializeDocumentation();
            return Get();
        }
    }
}
