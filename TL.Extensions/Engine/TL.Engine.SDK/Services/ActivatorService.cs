using ExtCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TL.Engine.SDK.Services
{
    public class ActivatorService : IActivatorService
    {
        IServiceProvider ServiceProvider { get; }

        public ActivatorService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }


        public Type GetImplementation<T>(bool useCaching = false)
        {
            return GetImplementations<T>(useCaching).FirstOrDefault();
        }

        public Type GetImplementation<T>(Func<Assembly, bool> predicate, bool useCaching = false)
        {
            return GetImplementations<T>(predicate, useCaching).FirstOrDefault();
        }


        public IEnumerable<Type> GetImplementations<T>(bool useCaching = false)
        {
            return GetImplementations<T>(null, useCaching);
        }

        public IEnumerable<Type> GetImplementations<T>(Func<Assembly, bool> predicate, bool useCaching = false)
        {
            return ExtensionManager.GetImplementations<T>(predicate, useCaching);
        }


        public T GetInstance<T>(bool useCaching = false)
        {
            return GetInstance<T>(null, useCaching);
        }

        public T GetInstance<T>(Func<Assembly, bool> predicate, bool useCaching = false)
        {
            return GetInstances<T>(predicate, useCaching).FirstOrDefault();
        }


        public IEnumerable<T> GetInstances<T>(bool useCaching = false)
        {
            return GetInstances<T>(null, useCaching);
        }

        public IEnumerable<T> GetInstances<T>(Func<Assembly, bool> predicate, bool useCaching = false)
        {
            List<T> instances = new List<T>();

            foreach (Type implementation in GetImplementations<T>(predicate, useCaching))
            {
                if (!implementation.GetTypeInfo().IsAbstract)
                {
                    T instance = (T)ActivatorUtilities.GetServiceOrCreateInstance(ServiceProvider, implementation);

                    instances.Add(instance);
                }
            }

            return instances;
        }


        public T GetServiceOrCreateInstance<T>()
        {
            return ActivatorUtilities.GetServiceOrCreateInstance<T>(ServiceProvider);
        }

        public object GetServiceOrCreateInstance(Type type)
        {
            return ActivatorUtilities.GetServiceOrCreateInstance(ServiceProvider, type);
        }
    }
}
