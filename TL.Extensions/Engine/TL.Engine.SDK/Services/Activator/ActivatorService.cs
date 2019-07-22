using ExtCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TL.Engine.SDK.Services
{
    /// <summary>
    /// Сервис создания объектов с использованием внедрения зависимостей.
    /// </summary>
    internal class ActivatorService : IActivatorService
    {
        readonly ConcurrentDictionary<Type, IEnumerable<Type>> _types;

        IServiceProvider ServiceProvider { get; }

        public IEnumerable<Assembly> Assemblies { get; }

        public ActivatorService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
            Assemblies = ExtensionManager.Assemblies;
            _types = new ConcurrentDictionary<Type, IEnumerable<Type>>();
        }

        IEnumerable<Assembly> GetAssemblies(Func<Assembly, bool> predicate)
        {
            if (predicate == null)
                return ExtensionManager.Assemblies;

            return ExtensionManager.Assemblies.Where(predicate);
        }

        /// <summary>
        /// Получить реализацию типа <paramref name="targetType" />
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetImplementation(Type targetType, bool useCaching = false)
        {
            return GetImplementations(targetType, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить реализацию типа <paramref name="targetType" />, удовлетворяющую предикату.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetImplementation(Type targetType, Func<Assembly, bool> predicate, bool useCaching = false)
        {
            return GetImplementations(targetType, predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить все реализации типа <paramref name="targetType" />.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetImplementations(Type targetType, bool useCaching = false)
        {
            return GetImplementations(targetType, null, useCaching);
        }

        /// <summary>
        /// Получить все реализации типа <paramref name="targetType" />, удовлетворяющие предикату.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetImplementations(Type targetType, Func<Assembly, bool> predicate, bool useCaching = false)
        {
            if (useCaching && _types.ContainsKey(targetType))
                return _types[targetType];

            List<Type> implementations = new List<Type>();

            foreach (Assembly assembly in GetAssemblies(predicate))
                foreach (Type exportedType in assembly.GetExportedTypes())
                    if (targetType.GetTypeInfo().IsAssignableFrom(exportedType) && exportedType.GetTypeInfo().IsClass)
                        implementations.Add(exportedType);

            if (useCaching)
                _types[targetType] = implementations;

            return implementations;
        }

        /// <summary>
        /// Получить экземпляр типа <paramref name="targetType" />.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public object GetInstance(Type targetType, bool useCaching = false)
        {
            return GetInstance(targetType, null, useCaching);
        }

        /// <summary>
        /// Получить экземпляр типа <paramref name="targetType" />, удовлетворяющую предикату.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public object GetInstance(Type targetType, Func<Assembly, bool> predicate, bool useCaching = false)
        {
            return GetInstances(targetType, predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить все экземпляры типа <paramref name="targetType" />.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<object> GetInstances(Type targetType, bool useCaching = false)
        {
            return GetInstances(targetType, null, useCaching);
        }

        /// <summary>
        /// Получить все экземпляры типа <paramref name="targetType" />, удовлетворяющие предикату.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<object> GetInstances(Type targetType, Func<Assembly, bool> predicate, bool useCaching = false)
        {
            List<object> instances = new List<object>();

            foreach (Type implementation in GetImplementations(targetType, predicate, useCaching))
            {
                if (!implementation.GetTypeInfo().IsAbstract)
                {
                    var instance = ActivatorUtilities.GetServiceOrCreateInstance(ServiceProvider, implementation);

                    instances.Add(instance);
                }
            }

            return instances;
        }

        /// <summary>
        /// Получить реализацию типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetImplementation<T>(bool useCaching = false)
        {
            return GetImplementations<T>(useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить реализацию типа <typeparamref name="T" />, удовлетворяющую предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetImplementation<T>(Func<Assembly, bool> predicate, bool useCaching = false)
        {
            return GetImplementations<T>(predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить все реализации типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetImplementations<T>(bool useCaching = false)
        {
            return GetImplementations<T>(null, useCaching);
        }

        /// <summary>
        /// Получить все реализации типа <typeparamref name="T" />, удовлетворяющие предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetImplementations<T>(Func<Assembly, bool> predicate, bool useCaching = false)
        {
            return GetImplementations(typeof(T), predicate, useCaching);
        }

        /// <summary>
        /// Получить экземпляр типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public T GetInstance<T>(bool useCaching = false)
        {
            return GetInstance<T>(null, useCaching);
        }

        /// <summary>
        /// Получить экземпляр типа <typeparamref name="T" />, удовлетворяющую предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public T GetInstance<T>(Func<Assembly, bool> predicate, bool useCaching = false)
        {
            return GetInstances<T>(predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить все экземпляры типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<T> GetInstances<T>(bool useCaching = false)
        {
            return GetInstances<T>(null, useCaching);
        }

        /// <summary>
        /// Получить все экземпляры типа <typeparamref name="T" />, удовлетворяющие предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Получить сервис или создать экземпляр типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <returns></returns>
        public T GetServiceOrCreateInstance<T>()
        {
            return ActivatorUtilities.GetServiceOrCreateInstance<T>(ServiceProvider);
        }

        /// <summary>
        /// Получить сервис или создать экземпляр типа <typeparamref name="T" />.
        /// </summary>
        /// <param name="type">Целевой тип</param>
        /// <returns></returns>
        public object GetServiceOrCreateInstance(Type type)
        {
            return ActivatorUtilities.GetServiceOrCreateInstance(ServiceProvider, type);
        }

        /// <summary>
        /// Создать экземпляр типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <returns></returns>
        public T CreateInstance<T>()
        {
            return ActivatorUtilities.CreateInstance<T>(ServiceProvider);
        }

        /// <summary>
        /// Создать экземпляр типа <typeparamref name="T" />.
        /// </summary>
        /// <param name="type">Целевой тип</param>
        /// <returns></returns>
        public object CreateInstance(Type type)
        {
            return ActivatorUtilities.CreateInstance(ServiceProvider, type);
        }
    }
}
