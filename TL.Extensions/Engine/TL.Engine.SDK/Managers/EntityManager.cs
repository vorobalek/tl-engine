using ExtCore.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.SDK.Managers
{
    public abstract class EntityManager<TEntity> : IEntityManager<TEntity>
        where TEntity : class, IEntity
    {
        public EntityManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory)
        {
            Logger = loggerFactory.CreateLogger(GetType());
            ServiceProvider = serviceProvider;
            Storage = storage;
        }

        protected ILogger Logger { get; }
        protected IServiceProvider ServiceProvider { get; }
        protected IStorage Storage { get; }

        public virtual TEntity Create(TEntity entity)
        {
            if (entity == null)
            {
                return CreateEmpty();
            }
            else
            {
                TEntity createdEntity = null;
                try
                {
                    createdEntity = Storage.GetRepository<IEntityRepository<TEntity>>().Add(entity);
                    Storage.Save();
                }
                catch (Exception ex)
                {
                    Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
                }
                return createdEntity;
            }
        }

        public virtual TEntity CreateEmpty()
        {
            TEntity createdEntity = null;
            try
            {
                TEntity entity = ActivatorUtilities.CreateInstance(ServiceProvider, typeof(TEntity)) as TEntity;
                return Create(entity);
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось создать пустой экземпляр сущности\r\n{ex}");
            }
            return createdEntity;
        }

        public virtual TEntity Delete(TEntity entity)
        {
            TEntity returnableEntity = null;
            try
            {
                returnableEntity = Storage.GetRepository<IEntityRepository<TEntity>>().Delete(entity);
                Storage.Save();
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return returnableEntity;
        }

        public virtual TEntity Delete(Func<TEntity, bool> predicate)
        {
            TEntity entity = null;
            try
            {
                var repository = Storage.GetRepository<IEntityRepository<TEntity>>();
                entity = repository.Delete(repository.Get(predicate));
                Storage.Save();
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return entity;
        }

        public IEnumerable<TEntity> DeleteAll(Func<TEntity, bool> predicate)
        {
            var returnableEntities = new List<TEntity>();
            try
            {
                var repository = Storage.GetRepository<IEntityRepository<TEntity>>();
                var entities = GetAll(predicate).ToArray();
                for (int i = 0; i < entities.Length; ++i)
                {
                    returnableEntities.Add(repository.Delete(entities[i]));
                }
                Storage.Save();
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return returnableEntities;
        }

        public virtual TEntity Get(Func<TEntity, bool> predicate)
        {
            return Storage.GetRepository<IEntityRepository<TEntity>>().Get(predicate);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return GetAll(e => true);
        }

        public virtual IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
            IEnumerable<TEntity> entities = Storage.GetRepository<IEntityRepository<TEntity>>().GetAll(predicate);
            return entities;
        }

        public virtual TEntity GetOrCreate(Func<TEntity, bool> predicate, TEntity entity = null)
        {
            TEntity existedEntity = Get(predicate);
            if (existedEntity == null)
            {
                return Create(entity);
            }
            return existedEntity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            try
            {
                TEntity updatedEntity = Storage.GetRepository<IEntityRepository<TEntity>>().Update(entity);
                Storage.Save();
                return updatedEntity;
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return null;
        }
    }
}
