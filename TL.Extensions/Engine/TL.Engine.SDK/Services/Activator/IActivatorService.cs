using System;
using System.Collections.Generic;
using System.Reflection;

namespace TL.Engine.SDK.Services
{
    public interface IActivatorService
    {
        Type GetImplementation<T>(bool useCaching = false);
        Type GetImplementation<T>(Func<Assembly, bool> predicate, bool useCaching = false);

        IEnumerable<Type> GetImplementations<T>(bool useCaching = false);
        IEnumerable<Type> GetImplementations<T>(Func<Assembly, bool> predicate, bool useCaching = false);

        T GetInstance<T>(bool useCaching = false);
        T GetInstance<T>(Func<Assembly, bool> predicate, bool useCaching = false);

        IEnumerable<T> GetInstances<T>(bool useCaching = false);
        IEnumerable<T> GetInstances<T>(Func<Assembly, bool> predicate, bool useCaching = false);

        T GetServiceOrCreateInstance<T>();
        object GetServiceOrCreateInstance(Type type);
    }
}