using System;
using System.Collections.Generic;
using System.Reflection;

namespace TL.Engine.SDK.Services
{
    /// <summary>
    /// Интерфейс сервиса создания объектов с использованием внедрения зависимостей.
    /// </summary>
    public interface IActivatorService
    {
        /// <summary>
        /// Получить реализацию типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        Type GetImplementation<T>(bool useCaching = false);

        /// <summary>
        /// Получить реализацию типа <typeparamref name="T"/>, удовлетворяющую предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        Type GetImplementation<T>(Func<Assembly, bool> predicate, bool useCaching = false);

        /// <summary>
        /// Получить все реализации типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        IEnumerable<Type> GetImplementations<T>(bool useCaching = false);

        /// <summary>
        /// Получить все реализации типа <typeparamref name="T"/>, удовлетворяющие предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        IEnumerable<Type> GetImplementations<T>(Func<Assembly, bool> predicate, bool useCaching = false);

        /// <summary>
        /// Получить экземпляр типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        T GetInstance<T>(bool useCaching = false);

        /// <summary>
        /// Получить экземпляр типа <typeparamref name="T"/>, удовлетворяющую предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        T GetInstance<T>(Func<Assembly, bool> predicate, bool useCaching = false);

        /// <summary>
        /// Получить все экземпляры типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        IEnumerable<T> GetInstances<T>(bool useCaching = false);

        /// <summary>
        /// Получить все экземпляры типа <typeparamref name="T"/>, удовлетворяющие предикату.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="useCaching">Если <c>true</c> будет использован локальный кэш.</param>
        /// <returns></returns>
        IEnumerable<T> GetInstances<T>(Func<Assembly, bool> predicate, bool useCaching = false);

        /// <summary>
        /// Получить сервис или создать экземпляр типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип</typeparam>
        /// <returns></returns>
        T GetServiceOrCreateInstance<T>();

        /// <summary>
        /// Получить сервис или создать экземпляр типа <typeparamref name="T"/>.
        /// </summary>
        /// <param name="type">Целевой тип</param>
        /// <returns></returns>
        object GetServiceOrCreateInstance(Type type);
    }
}