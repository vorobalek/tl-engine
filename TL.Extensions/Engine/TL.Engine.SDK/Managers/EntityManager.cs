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

        public virtual TEntity Create(TEntity entity, bool cacheOnly = false)
        {
            if (entity == null)
            {
                return CreateEmpty(cacheOnly);
            }
            else
            {
                try
                {
                    Logger.TLogInformation($"Попытка создать сущность:\t{entity.GetType().GetFullName()}");

                    //Pre Create Entity
                    bool preCreate = true;
                    var preCreateActions = ExtensionManager.GetInstances<IEntityActionPreCreate<TEntity>>();
                    foreach (var action in preCreateActions)
                    {
                        var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                        preCreate = preCreate && actionResult;
                        Logger.TLogWarning($"Действия перед созданием сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (preCreate)
                    {
                        //Create Entity
                        Logger.TLogInformation($"Все действия перед созданием сущности успешно выполнены:\t{entity.GetType().GetFullName()}");

                        if (!cacheOnly)
                        {
                            entity = Storage.GetRepository<IEntityRepository<TEntity>>().Add(entity);
                        }
                        Logger.TLogInformation($"Создана сущность:\t{entity.GetType().GetFullName()}");

                        //Post Create Entity
                        bool postCreate = true;
                        var postCreateActions = ExtensionManager.GetInstances<IEntityActionPostCreate<TEntity>>();
                        foreach (var action in postCreateActions)
                        {
                            var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                            postCreate = postCreate && actionResult;
                            Logger.TLogWarning($"Действия после создания сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                        }

                        if (postCreate)
                        {
                            Logger.TLogInformation($"Все действия после создания сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                            return Save(entity, cacheOnly);
                        }
                        else
                        {
                            Logger.TLogError($"Не все действия после создания сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
                }
            }
            return null;
        }

        public virtual TEntity CreateEmpty(bool cacheOnly = false)
        {
            try
            {
                //Initialize Entity
                Logger.TLogInformation($"Запрос создания сущности:\t{typeof(TEntity).GetFullName()}");
                var entity = ActivatorUtilities.CreateInstance(ServiceProvider, typeof(TEntity)) as TEntity;

                //Can Create Entity
                bool canCreate = true;
                var canCreateActions = ExtensionManager.GetInstances<IEntityActionCanCreate<TEntity>>();
                foreach (var action in canCreateActions)
                {
                    var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                    canCreate = canCreate && actionResult;
                    Logger.TLogWarning($"Проверка перед созданием сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (canCreate)
                {
                    Logger.TLogInformation($"Сущность может быть создана:\t{entity.GetType().GetFullName()}");
                    return Create(entity, cacheOnly);
                }
                else
                {
                    Logger.TLogError($"Сущность не может быть создана:\t{entity.GetType().GetFullName()}");
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось создать пустой экземпляр сущности\r\n{ex}");
            }
            return null;
        }

        public virtual TEntity Delete(TEntity entity, bool cacheOnly = false)
        {
            try
            {
                //Can Delete Entity
                Logger.TLogInformation($"Запрос удаления сущности:\t{typeof(TEntity).GetFullName()}");
                bool canDelete = true;
                var canDeleteActions = ExtensionManager.GetInstances<IEntityActionCanDelete<TEntity>>();
                foreach (var action in canDeleteActions)
                {
                    var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                    canDelete = canDelete && actionResult;
                    Logger.TLogWarning($"Проверка перед удалением сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (canDelete)
                {
                    //Pre Delete Entity
                    Logger.TLogInformation($"Сущность может быть удалена:\t{entity.GetType().GetFullName()}");
                    bool preDelete = true;
                    var preDeleteActions = ExtensionManager.GetInstances<IEntityActionPreDelete<TEntity>>();
                    foreach (var action in preDeleteActions)
                    {
                        var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                        preDelete = preDelete && actionResult;
                        Logger.TLogWarning($"Действия перед удалением сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (preDelete)
                    {
                        //Delete Entity
                        Logger.TLogInformation($"Все действия перед удалением сущности успешно выполнены:\t{entity.GetType().GetFullName()}");

                        entity.IsDeleted = true;
                        var deletedEntity = Update(entity, true);

                        Logger.TLogInformation($"Удалена сущность:\t{entity.GetType().GetFullName()}");

                        //Post Delete Entity
                        bool postDelete = true;
                        var postDeleteActions = ExtensionManager.GetInstances<IEntityActionPostDelete<TEntity>>();
                        foreach (var action in postDeleteActions)
                        {
                            var actionResult = action.Invoke(ref deletedEntity, ServiceProvider, cacheOnly);
                            postDelete = postDelete && actionResult;
                            Logger.TLogWarning($"Действия после удаления сущности:\t{deletedEntity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                        }
                        if (postDelete)
                        {
                            Logger.TLogInformation($"Все действия после удаления сущности успешно выполнены:\t{deletedEntity.GetType().GetFullName()}");
                            return Save(deletedEntity, cacheOnly);
                        }
                        else
                        {
                            Logger.TLogError($"Не все действия после удаления сущности успешно выполнены:\t{deletedEntity.GetType().GetFullName()}");
                        }
                    }
                    else
                    {
                        Logger.TLogError($"Не все действия перед удалением сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                    }
                }
                else
                {
                    Logger.TLogError($"Сущность не может быть удалена:\t{entity.GetType().GetFullName()}");
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return null;
        }

        public virtual TEntity Delete(Func<TEntity, bool> predicate, bool cacheOnly = false)
        {
            return Delete(Get(predicate), cacheOnly);
        }

        public IEnumerable<TEntity> DeleteAll(Func<TEntity, bool> predicate, bool cacheOnly = false)
        {
            var returnableEntities = new List<TEntity>();
            var entities = GetAll(predicate).ToArray();
            for (int i = 0; i < entities.Length; ++i)
            {
                returnableEntities.Add(Delete(entities[i], cacheOnly));
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

        public virtual TEntity GetOrCreate(Func<TEntity, bool> predicate, bool loadDeleted = false, TEntity entity = null, bool cacheOnly = false)
        {
            TEntity existedEntity = Get(predicate, loadDeleted);
            if (existedEntity == null)
            {
                return Create(entity, cacheOnly);
            }
            return existedEntity;
        }

        public virtual TEntity Remove(TEntity entity, bool cacheOnly = false)
        {
            try
            {
                //Can Remove Entity
                Logger.TLogInformation($"Запрос уничтожения сущности:\t{typeof(TEntity).GetFullName()}");
                bool canRemove = true;
                var canRemoveActions = ExtensionManager.GetInstances<IEntityActionCanRemove<TEntity>>();
                foreach (var action in canRemoveActions)
                {
                    var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                    canRemove = canRemove && actionResult;
                    Logger.TLogWarning($"Проверка перед уничтожением сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (canRemove)
                {
                    ///Pre Remove Entity
                    Logger.TLogInformation($"Сущность может быть уничтожена:\t{entity.GetType().GetFullName()}");
                    bool preRemove = true;
                    var preRemoveActions = ExtensionManager.GetInstances<IEntityActionPreRemove<TEntity>>();
                    foreach (var action in preRemoveActions)
                    {
                        var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                        preRemove = preRemove && actionResult;
                        Logger.TLogWarning($"Действия перед уничтожением сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (preRemove)
                    {
                        //Remove Entity
                        Logger.TLogInformation($"Все действия перед уничтожением сущности успешно выполнены:\t{entity.GetType().GetFullName()}");

                        if (!cacheOnly)
                        {
                            entity = Storage.GetRepository<IEntityRepository<TEntity>>().Remove(entity);
                        }
                        Logger.TLogInformation($"Уничтожена сущность:\t{entity.GetType().GetFullName()}");

                        //Post Remove Entity
                        bool postRemove = true;
                        var postRemoveActions = ExtensionManager.GetInstances<IEntityActionPostRemove<TEntity>>();
                        foreach (var action in postRemoveActions)
                        {
                            var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                            postRemove = postRemove && actionResult;
                            Logger.TLogWarning($"Действия после уничтожения сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                        }
                        if (postRemove)
                        {
                            Logger.TLogInformation($"Все действия после уничтожения сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                            return Save(entity, cacheOnly);
                        }
                        else
                        {
                            Logger.TLogError($"Не все действия после уничтожения сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                        }
                    }
                    else
                    {
                        Logger.TLogError($"Не все действия перед уничтожением сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                    }
                }
                else
                {
                    Logger.TLogError($"Сущность не может быть уничтожена:\t{entity.GetType().GetFullName()}");
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return null;
        }

        public virtual TEntity Remove(Func<TEntity, bool> predicate, bool loadDeleted = false, bool cacheOnly = false)
        {
            return Remove(Get(predicate, loadDeleted), cacheOnly);
        }

        public virtual IEnumerable<TEntity> RemoveAll(Func<TEntity, bool> predicate, bool loadDeleted = false, bool cacheOnly = false)
        {
            var returnableEntities = new List<TEntity>();
            var entities = GetAll(predicate, loadDeleted).ToArray();
            for (int i = 0; i < entities.Length; ++i)
            {
                returnableEntities.Add(Remove(entities[i], cacheOnly));
            }
            return returnableEntities;
        }

        public virtual TEntity Update(TEntity entity, bool cacheOnly = false)
        {
            try
            {
                //Can Update Entity
                Logger.TLogInformation($"Запрос обновления сущности:\t{typeof(TEntity).GetFullName()}");
                bool canUpdate = true;
                var canUpdateActions = ExtensionManager.GetInstances<IEntityActionCanUpdate<TEntity>>();
                foreach (var action in canUpdateActions)
                {
                    var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                    canUpdate = canUpdate && actionResult;
                    Logger.TLogWarning($"Проверка перед обновлением сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (canUpdate)
                {
                    //Pre Update Entity
                    Logger.TLogInformation($"Сущность может быть обновлена:\t{entity.GetType().GetFullName()}");
                    bool preUpdate = true;
                    var preUpdateActions = ExtensionManager.GetInstances<IEntityActionPreUpdate<TEntity>>();
                    foreach (var action in preUpdateActions)
                    {
                        var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                        preUpdate = preUpdate && actionResult;
                        Logger.TLogWarning($"Действия перед обновлением сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (preUpdate)
                    {
                        //Update Entity
                        Logger.TLogInformation($"Все действия перед обновлением сущности успешно выполнены:\t{entity.GetType().GetFullName()}");

                        if (!cacheOnly)
                        {
                            entity = Storage.GetRepository<IEntityRepository<TEntity>>().Update(entity);
                        }
                        Logger.TLogInformation($"Обновлена сущность:\t{entity.GetType().GetFullName()}");

                        //Post Update Entity
                        bool postUpdate = true;
                        var postUpdateActions = ExtensionManager.GetInstances<IEntityActionPostUpdate<TEntity>>();
                        foreach (var action in postUpdateActions)
                        {
                            var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                            postUpdate = postUpdate && actionResult;
                            Logger.TLogWarning($"Действия после обновления сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                        }
                        if (postUpdate)
                        {
                            Logger.TLogInformation($"Все действия после обновления сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                            return Save(entity, cacheOnly);
                        }
                        else
                        {
                            Logger.TLogError($"Не все действия после обновления сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                        }
                    }
                    else
                    {
                        Logger.TLogError($"Не все действия перед обновлением сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                    }
                }
                else
                {
                    Logger.TLogError($"Сущность не может быть обновлена:\t{entity.GetType().GetFullName()}");
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return null;
        }

        protected TEntity Save(TEntity entity, bool cacheOnly = false)
        {
            //Can Save Entity
            Logger.TLogInformation($"Попытка сохранить сущность:\t{entity.GetType().GetFullName()}");
            bool canSave = true;
            var canSaveActions = ExtensionManager.GetInstances<IEntityActionCanSave<TEntity>>();
            foreach (var action in canSaveActions)
            {
                var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                canSave = canSave && actionResult;
                Logger.TLogWarning($"Проверка условий сохранения сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
            }

            if (canSave)
            {
                //Pre Save Entity
                Logger.TLogInformation($"Сущность может быть сохранена:\t{entity.GetType().GetFullName()}");
                bool preSave = true;
                var preSaveActions = ExtensionManager.GetInstances<IEntityActionPreSave<TEntity>>();
                foreach (var action in preSaveActions)
                {
                    var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                    preSave = preSave && actionResult;
                    Logger.TLogWarning($"Действия перед сохранением сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (preSave)
                {
                    //Save Entity
                    Logger.TLogInformation($"Все действия перед сохранением сущности успешно выполнены:\t{entity.GetType().GetFullName()}");

                    if (!cacheOnly)
                    {
                        Storage.Save();
                    }
                    Logger.TLogWarning($"Сохранена сущность:\t{entity.GetType().GetFullName()}");

                    //Post Save Entity
                    bool postSave = true;
                    var postSaveActions = ExtensionManager.GetInstances<IEntityActionPostSave<TEntity>>();
                    foreach (var action in postSaveActions)
                    {
                        var actionResult = action.Invoke(ref entity, ServiceProvider, cacheOnly);
                        postSave = postSave && actionResult;
                        Logger.TLogWarning($"Действия после сохранения сущности:\t{entity.GetType().GetFullName()}:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (postSave)
                    {
                        Logger.TLogInformation($"Все действия после сохранения сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                    }
                    else
                    {
                        Logger.TLogError($"Не все действия после сохранения сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                    }
                }
                else
                {
                    Logger.TLogError($"Не все действия перед сохранением сущности успешно выполнены:\t{entity.GetType().GetFullName()}");
                }
            }
            else
            {
                Logger.TLogError($"Сущность не может быть сохранена:\t{entity.GetType().GetFullName()}");
            }
            return entity;
        }
    }
}
