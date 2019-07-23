using ExtCore.Data.Abstractions;
using ExtCore.Data.Entities.Abstractions;
using System;
using System.Linq;
using System.Reflection;
using TL.Engine.SDK.Services;
using IRepository = TL.Engine.SDK.Repositories.IRepository;

namespace TL.Engine.SDK.Extensions
{
    public static class StorageExtensions
    {
        public static IRepository GetEntityRepository<TEntity>(this IStorage storage, IActivatorService activator)
            where TEntity : IEntity
        {
            var entityType = activator.GetImplementations<TEntity>().Where(t => !t.GetTypeInfo().IsAbstract).FirstOrDefault();
            var repositories = activator.GetInstances<IRepository>().Where(rep => rep.EntityType.IsAssignableFrom(entityType));
            var repository = repositories.FirstOrDefault();
            repository.SetStorageContext(storage.StorageContext);
            return repository;
        }

        public static IRepository GetEntityRepository(this IStorage storage, IActivatorService activator, Type entityType)
        {
            var repositories = activator.GetInstances<IRepository>().Where(rep => rep.EntityType.IsAssignableFrom(entityType));
            var repository = repositories.FirstOrDefault();
            repository.SetStorageContext(storage.StorageContext);
            return repository;
        }
    }
}
