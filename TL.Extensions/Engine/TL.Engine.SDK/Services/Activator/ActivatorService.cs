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
        private static ConcurrentDictionary<Type, IEnumerable<Type>> _implementations = new ConcurrentDictionary<Type, IEnumerable<Type>>();
        private static ConcurrentDictionary<Type, IEnumerable<Type>> _inheritors = new ConcurrentDictionary<Type, IEnumerable<Type>>();

        private static IEnumerable<Assembly> _assemblies = ExtensionManager.Assemblies;

        IServiceProvider ServiceProvider { get; }

        public IEnumerable<Assembly> Assemblies { get => _assemblies; }

        public ActivatorService(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        /// <summary>
        /// Получить наследника типа <paramref name="targetType"/>
        /// </summary>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetInheritor(Type targetType, bool useCaching = true)
        {
            return GetInheritors(targetType, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить наследника типа <paramref name="targetType"/>, удовлетворяющую предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetInheritor(Type targetType, Func<Assembly, bool> predicate, bool useCaching = true)
        {
            return GetInheritors(targetType, predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить всех наследников типа <paramref name="targetType"/>.
        /// </summary>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetInheritors(Type targetType, bool useCaching = true)
        {
            return GetInheritors(targetType, null, useCaching);
        }

        /// <summary>
        /// Получить всех наследников типа <paramref name="targetType"/>, удовлетворяющие предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetInheritors(Type targetType, Func<Assembly, bool> predicate, bool useCaching = true)
        {
            if (useCaching && _inheritors.ContainsKey(targetType))
                return _inheritors[targetType];

            List<Type> inheritors = new List<Type>();

            foreach (Assembly assembly in GetAssemblies(predicate))
                foreach (Type exportedType in assembly.GetExportedTypes())
                    if (targetType.GetTypeInfo().IsAssignableFrom(exportedType))
                        inheritors.Add(exportedType);

            if (useCaching)
                _inheritors[targetType] = inheritors;

            return inheritors;
        }

        /// <summary>
        /// Получить наследника типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetInheritor<T>(bool useCaching = true)
        {
            return GetInheritors<T>(useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить наследника типа <typeparamref name="T"/>, удовлетворяющую предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetInheritor<T>(Func<Assembly, bool> predicate, bool useCaching = true)
        {
            return GetInheritors<T>(predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить всех наследников типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetInheritors<T>(bool useCaching = true)
        {
            return GetInheritors<T>(null, useCaching);
        }

        /// <summary>
        /// Получить всех наследников типа <typeparamref name="T"/>, удовлетворяющие предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetInheritors<T>(Func<Assembly, bool> predicate, bool useCaching = true)
        {
            return GetInheritors(typeof(T), predicate, useCaching);
        }

        IEnumerable<Assembly> GetAssemblies(Func<Assembly, bool> predicate)
        {
            if (predicate == null)
                return Assemblies;

            return Assemblies.Where(predicate);
        }

        /// <summary>
        /// Получить реализацию типа <paramref name="targetType" />
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public Type GetImplementation(Type targetType, bool useCaching = true)
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
        public Type GetImplementation(Type targetType, Func<Assembly, bool> predicate, bool useCaching = true)
        {
            return GetImplementations(targetType, predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить все реализации типа <paramref name="targetType" />.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetImplementations(Type targetType, bool useCaching = true)
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
        public IEnumerable<Type> GetImplementations(Type targetType, Func<Assembly, bool> predicate, bool useCaching = true)
        {
            if (useCaching && _implementations.ContainsKey(targetType))
                return _implementations[targetType];

            List<Type> implementations = new List<Type>();

            foreach (Assembly assembly in GetAssemblies(predicate))
                foreach (Type exportedType in assembly.GetExportedTypes())
                    if (targetType.GetTypeInfo().IsAssignableFrom(exportedType) && exportedType.GetTypeInfo().IsClass)
                        implementations.Add(exportedType);

            if (useCaching)
                _implementations[targetType] = implementations;

            return implementations;
        }

        /// <summary>
        /// Получить экземпляр типа <paramref name="targetType" />.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public object GetInstance(Type targetType, bool useCaching = true)
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
        public object GetInstance(Type targetType, Func<Assembly, bool> predicate, bool useCaching = true)
        {
            return GetInstances(targetType, predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить все экземпляры типа <paramref name="targetType" />.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<object> GetInstances(Type targetType, bool useCaching = true)
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
        public IEnumerable<object> GetInstances(Type targetType, Func<Assembly, bool> predicate, bool useCaching = true)
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
        public Type GetImplementation<T>(bool useCaching = true)
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
        public Type GetImplementation<T>(Func<Assembly, bool> predicate, bool useCaching = true)
        {
            return GetImplementations<T>(predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить все реализации типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<Type> GetImplementations<T>(bool useCaching = true)
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
        public IEnumerable<Type> GetImplementations<T>(Func<Assembly, bool> predicate, bool useCaching = true)
        {
            return GetImplementations(typeof(T), predicate, useCaching);
        }

        /// <summary>
        /// Получить экземпляр типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public T GetInstance<T>(bool useCaching = true)
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
        public T GetInstance<T>(Func<Assembly, bool> predicate, bool useCaching = true)
        {
            return GetInstances<T>(predicate, useCaching).FirstOrDefault();
        }

        /// <summary>
        /// Получить все экземпляры типа <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        public IEnumerable<T> GetInstances<T>(bool useCaching = true)
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
        public IEnumerable<T> GetInstances<T>(Func<Assembly, bool> predicate, bool useCaching = true)
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
        /// Получить сервис типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <returns></returns>
        public T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }

        /// <summary>
        /// Получить сервис типа <typeparamref name="T"/>.
        /// </summary>
        /// <param name="type">Целевой тип</param>
        /// <returns></returns>
        public object GetService(Type type)
        {
            return ServiceProvider.GetService(type);
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
