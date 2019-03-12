using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TL.Api.SDK.Attributes.Executable;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Controllers;
using TL.Api.SDK.Models;
using TL.Api.SDK.Objects;
using TL.Engine.SDK.Extensions;

namespace TL.Api.SDK.Services.ApiDocumentation
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
            InitializeFunctions();
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
                                    ReturnableType = apiprotocol?.ReturnableType.GetFullName(),
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
                                    Type = prop.PropertyType.GetFullName()
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
            ApiDocumentationModel.Functions = ExtensionManager.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectMany(t => t.GetMethods())
                .Where(m => m.GetCustomAttributes(typePrivateApiAttribute, true).Length > 0)
                .Select(m =>
                {
                    return new ApiFunctionModel()
                    {
                        Namespace = m.DeclaringType.FullName,
                        Name = m.Name,
                        Description = (m.GetCustomAttributes(typePrivateApiAttribute, true).FirstOrDefault() as PrivateApiAttribute).Description,
                        ReturnableType = m.ReturnType.GetFullName(),
                        Properties = m.GetParameters().Select(p =>
                        {
                            return new ApiPropertyModel()
                            {
                                Type = p.ParameterType.GetFullName(),
                                Name = p.Name,
                            };
                        }).ToList(),
                        IsPrivate = m.GetCustomAttributes(typePublicApiAttribute, false).Count() > 0 ? false : true
                    };
                })
                .ToList();
        }
    }
}
