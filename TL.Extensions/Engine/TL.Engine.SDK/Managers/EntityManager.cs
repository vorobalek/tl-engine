using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Actions;
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
                    //Pre Create Entity
                    bool preCreate = true;
                    var preCreateActions = ExtensionManager.GetInstances<IEntityActionPreCreate<TEntity>>();
                    foreach (var action in preCreateActions)
                    {
                        preCreate = preCreate && action.Invoke(ref entity, ServiceProvider);
                    }
                    if (preCreate)
                    {
                        createdEntity = Storage.GetRepository<IEntityRepository<TEntity>>().Add(entity);
                        
                        //Post Create Entity
                        bool postCreate = true;
                        var postCreateActions = ExtensionManager.GetInstances<IEntityActionPostCreate<TEntity>>();
                        foreach (var action in postCreateActions)
                        {
                            postCreate = postCreate && action.Invoke(ref entity, ServiceProvider);
                        }
                        if (postCreate)
                        {
                            //Can Save Entity
                            bool canSave = true;
                            var canSaveActions = ExtensionManager.GetInstances<IEntityActionCanSave<TEntity>>();
                            foreach (var action in canSaveActions)
                            {
                                canSave = canSave && action.Invoke(ref entity, ServiceProvider);
                            }
                            if (canSave)
                            {
                                //Pre Save Entity
                                bool preSave = true;
                                var preSaveActions = ExtensionManager.GetInstances<IEntityActionPreSave<TEntity>>();
                                foreach (var action in preSaveActions)
                                {
                                    preSave = preSave && action.Invoke(ref entity, ServiceProvider);
                                }
                                if (preSave)
                                {
                                    //Save Entity
                                    Storage.Save();

                                    //Post Save Entity
                                    bool postSave = true;
                                    var postSaveActions = ExtensionManager.GetInstances<IEntityActionPostSave<TEntity>>();
                                    foreach (var action in postSaveActions)
                                    {
                                        postSave = postSave && action.Invoke(ref entity, ServiceProvider);
                                    }
                                    if (postSave)
                                    {
                                        ;
                                    }
                                }
                            }
                        }
                    }
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
                var entity = ActivatorUtilities.CreateInstance(ServiceProvider, typeof(TEntity)) as TEntity;
                
                //Can Create Entity
                bool canCreate = true;
                var canCreateActions = ExtensionManager.GetInstances<IEntityActionCanCreate<TEntity>>();
                foreach (var action in canCreateActions)
                {
                    canCreate = canCreate && action.Invoke(ref entity, ServiceProvider);
                }
                if (canCreate)
                {
                    return Create(entity);
                }
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

        public virtual TEntity Get(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            return Storage.GetRepository<IEntityRepository<TEntity>>().Get(predicate, loadDeleted);
        }

        public virtual IEnumerable<TEntity> GetAll(bool loadDeleted = false)
        {
            return GetAll(e => true, loadDeleted);
        }

        public virtual IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            IEnumerable<TEntity> entities = Storage.GetRepository<IEntityRepository<TEntity>>().GetAll(predicate, loadDeleted);
            return entities;
        }

        public virtual TEntity GetOrCreate(Func<TEntity, bool> predicate, bool loadDeleted = false, TEntity entity = null)
        {
            TEntity existedEntity = Get(predicate, loadDeleted);
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
                //Can Update Entity
                bool canUpdate = true;
                var canUpdateActions = ExtensionManager.GetInstances<IEntityActionCanUpdate<TEntity>>();
                foreach (var action in canUpdateActions)
                {
                    canUpdate = canUpdate && action.Invoke(ref entity, ServiceProvider);
                }
                if (canUpdate)
                {
                    //Pre Update Entity
                    bool preUpdate = true;
                    var preUpdateActions = ExtensionManager.GetInstances<IEntityActionPreUpdate<TEntity>>();
                    foreach (var action in preUpdateActions)
                    {
                        preUpdate = preUpdate && action.Invoke(ref entity, ServiceProvider);
                    }
                    if (preUpdate)
                    {
                        TEntity updatedEntity = Storage.GetRepository<IEntityRepository<TEntity>>().Update(entity);
                        
                        //Post Update Entity
                        bool postUpdate = true;
                        var postUpdateActions = ExtensionManager.GetInstances<IEntityActionPostUpdate<TEntity>>();
                        foreach (var action in postUpdateActions)
                        {
                            postUpdate = postUpdate && action.Invoke(ref entity, ServiceProvider);
                        }
                        if (postUpdate)
                        {
                            //Can Save Entity
                            bool canSave = true;
                            var canSaveActions = ExtensionManager.GetInstances<IEntityActionCanSave<TEntity>>();
                            foreach (var action in canSaveActions)
                            {
                                canSave = canSave && action.Invoke(ref entity, ServiceProvider);
                            }
                            if (canSave)
                            {
                                //Pre Save Entity
                                bool preSave = true;
                                var preSaveActions = ExtensionManager.GetInstances<IEntityActionPreSave<TEntity>>();
                                foreach (var action in preSaveActions)
                                {
                                    preSave = preSave && action.Invoke(ref entity, ServiceProvider);
                                }
                                if (preSave)
                                {
                                    //Save Entity
                                    Storage.Save();

                                    //Post Save Entity
                                    bool postSave = true;
                                    var postSaveActions = ExtensionManager.GetInstances<IEntityActionPostSave<TEntity>>();
                                    foreach (var action in postSaveActions)
                                    {
                                        postSave = postSave && action.Invoke(ref entity, ServiceProvider);
                                    }
                                    if (postSave)
                                    {
                                        ;
                                    }

                                    return updatedEntity;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return null;
        }
    }
}
