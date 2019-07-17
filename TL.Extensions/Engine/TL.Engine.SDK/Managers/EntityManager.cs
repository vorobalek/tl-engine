using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Repositories;
using TL.Engine.SDK.Services;

namespace TL.Engine.SDK.Managers
{
    /// <summary>
    /// Абстрактная реализация менеджера элементарных сущностей <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <seealso cref="IEntityManager{TEntity}" />
    public abstract class EntityManager<TEntity> : IEntityManager<TEntity>
        where TEntity : class, IEntity
    {
        protected IActivatorService Activator { get; }

        public EntityManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage)
        {
            Activator = activator;
            Logger = loggerFactory.CreateLogger(GetType());
            Storage = storage;
        }

        /// <summary>
        /// Целевой тип.
        /// </summary>
        public Type TargetType => typeof(TEntity);

        protected ILogger Logger { get; }
        protected IStorage Storage { get; }

        /// <summary>
        /// Создать экземпляр сущности типа <typeparamref name="TEntity" /> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
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
                    Logger.TLogInformation($"Запрос создания сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                    //Can Create Entity
                    bool canCreate = true;
                    var canCreateActions = Activator.GetInstances<IEntityActionCanCreate<TEntity>>();
                    foreach (var action in canCreateActions)
                    {
                        var actionResult = action.Invoke(ref entity, cacheOnly);
                        canCreate = canCreate && actionResult;
                        Logger.TLogWarning($"Проверка перед созданием сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (canCreate)
                    {
                        Logger.TLogInformation($"Попытка создать сущность:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                        //Pre Create Entity
                        bool preCreate = true;
                        var preCreateActions = Activator.GetInstances<IEntityActionPreCreate<TEntity>>();
                        foreach (var action in preCreateActions)
                        {
                            var actionResult = action.Invoke(ref entity, cacheOnly);
                            preCreate = preCreate && actionResult;
                            Logger.TLogWarning($"Действия перед созданием сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                        }

                        if (preCreate)
                        {
                            //Create Entity
                            Logger.TLogInformation($"Все действия перед созданием сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                            if (!cacheOnly)
                            {
                                entity = Storage.GetRepository<IEntityRepository<TEntity>>().Add(entity);
                            }
                            Logger.TLogInformation($"Создана сущность:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                            //Post Create Entity
                            bool postCreate = true;
                            var postCreateActions = Activator.GetInstances<IEntityActionPostCreate<TEntity>>();
                            foreach (var action in postCreateActions)
                            {
                                var actionResult = action.Invoke(ref entity, cacheOnly);
                                postCreate = postCreate && actionResult;
                                Logger.TLogWarning($"Действия после создания сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                            }

                            if (postCreate)
                            {
                                Logger.TLogInformation($"Все действия после создания сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                                return Save(entity, cacheOnly);
                            }
                            else
                            {
                                Logger.TLogError($"Не все действия после создания сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                            }
                        }
                    }
                    else
                    {
                        Logger.TLogError($"Сущность не может быть создана:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    }
                }
                catch (Exception ex)
                {
                    Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
                }
            }
            return null;
        }

        /// <summary>
        /// Создать экземпляр пустой сущности типа <typeparamref name="TEntity" /> в хранилище.
        /// </summary>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity CreateEmpty(bool cacheOnly = false)
        {
            try
            {
                if (Activator.GetServiceOrCreateInstance<TEntity>() is TEntity entity)
                {
                    return Create(entity, cacheOnly);
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось создать пустой экземпляр сущности\t{nameof(cacheOnly)}={cacheOnly}\r\n{ex}");
            }
            return null;
        }

        /// <summary>
        /// Удалить экземпляр сущности типа <typeparamref name="TEntity" /> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Delete(TEntity entity, bool cacheOnly = false)
        {
            try
            {
                //Can Delete Entity
                Logger.TLogInformation($"Запрос удаления сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                bool canDelete = true;
                var canDeleteActions = Activator.GetInstances<IEntityActionCanDelete<TEntity>>();
                foreach (var action in canDeleteActions)
                {
                    var actionResult = action.Invoke(ref entity, cacheOnly);
                    canDelete = canDelete && actionResult;
                    Logger.TLogWarning($"Проверка перед удалением сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (canDelete)
                {
                    //Pre Delete Entity
                    Logger.TLogInformation($"Сущность может быть удалена:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    bool preDelete = true;
                    var preDeleteActions = Activator.GetInstances<IEntityActionPreDelete<TEntity>>();
                    foreach (var action in preDeleteActions)
                    {
                        var actionResult = action.Invoke(ref entity, cacheOnly);
                        preDelete = preDelete && actionResult;
                        Logger.TLogWarning($"Действия перед удалением сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (preDelete)
                    {
                        //Delete Entity
                        Logger.TLogInformation($"Все действия перед удалением сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                        entity.IsDeleted = true;
                        entity = Update(entity);

                        Logger.TLogInformation($"Удалена сущность:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                        //Post Delete Entity
                        bool postDelete = true;
                        var postDeleteActions = Activator.GetInstances<IEntityActionPostDelete<TEntity>>();
                        foreach (var action in postDeleteActions)
                        {
                            var actionResult = action.Invoke(ref entity, cacheOnly);
                            postDelete = postDelete && actionResult;
                            Logger.TLogWarning($"Действия после удаления сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                        }
                        if (postDelete)
                        {
                            Logger.TLogInformation($"Все действия после удаления сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                            return entity;
                        }
                        else
                        {
                            Logger.TLogError($"Не все действия после удаления сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                        }
                    }
                    else
                    {
                        Logger.TLogError($"Не все действия перед удалением сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    }
                }
                else
                {
                    Logger.TLogError($"Сущность не может быть удалена:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return null;
        }

        /// <summary>
        /// Удалить экземпляр сущности типа <typeparamref name="TEntity" />, удовлетворяющей предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Delete(Func<TEntity, bool> predicate, bool cacheOnly = false)
        {
            return Delete(Get(predicate), cacheOnly);
        }

        /// <summary>
        /// Удалить все сущности типа <typeparamref name="TEntity" />, удовлетворяющие предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Коллекция экземпляров отслеживаемых сущностей.
        /// </returns>
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

        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity" />, удовлетворяющей предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Get(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            return Storage.GetRepository<IEntityRepository<TEntity>>().Get(predicate, loadDeleted);
        }

        /// <summary>
        /// Получить все сущности типа <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>
        /// Коллекция экземпляров отслеживаемых сущностей.
        /// </returns>
        public virtual IEnumerable<TEntity> GetAll(bool loadDeleted = false)
        {
            return GetAll(e => true, loadDeleted);
        }

        /// <summary>
        /// Получить все сущности типа <typeparamref name="TEntity" />, удовлетворяющие предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>
        /// Коллекция экземпляров отслеживаемых сущностей.
        /// </returns>
        public virtual IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            IEnumerable<TEntity> entities = Storage.GetRepository<IEntityRepository<TEntity>>().GetAll(predicate, loadDeleted);
            return entities;
        }

        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity" />, удовлетворяющей предикату или создать новый в хранилище.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity GetOrCreate(Func<TEntity, bool> predicate, bool loadDeleted = false, TEntity entity = null, bool cacheOnly = false)
        {
            TEntity existedEntity = Get(predicate, loadDeleted);
            if (existedEntity == null)
            {
                return Create(entity, cacheOnly);
            }
            return existedEntity;
        }

        /// <summary>
        /// Получить и отслеживать сущность из хранилища.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns></returns>
        public TEntity Load(TEntity entity)
        {
            return Storage.GetRepository<IEntityRepository<TEntity>>().Load(entity);
        }

        /// <summary>
        /// Уничтожить экземпляр сущности типа <typeparamref name="TEntity" /> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Remove(TEntity entity, bool cacheOnly = false)
        {
            try
            {
                //Can Remove Entity
                Logger.TLogInformation($"Запрос уничтожения сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                bool canRemove = true;
                var canRemoveActions = Activator.GetInstances<IEntityActionCanRemove<TEntity>>();
                foreach (var action in canRemoveActions)
                {
                    var actionResult = action.Invoke(ref entity, cacheOnly);
                    canRemove = canRemove && actionResult;
                    Logger.TLogWarning($"Проверка перед уничтожением сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (canRemove)
                {
                    ///Pre Remove Entity
                    Logger.TLogInformation($"Сущность может быть уничтожена:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    bool preRemove = true;
                    var preRemoveActions = Activator.GetInstances<IEntityActionPreRemove<TEntity>>();
                    foreach (var action in preRemoveActions)
                    {
                        var actionResult = action.Invoke(ref entity, cacheOnly);
                        preRemove = preRemove && actionResult;
                        Logger.TLogWarning($"Действия перед уничтожением сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (preRemove)
                    {
                        //Remove Entity
                        Logger.TLogInformation($"Все действия перед уничтожением сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                        if (!cacheOnly)
                        {
                            entity = Storage.GetRepository<IEntityRepository<TEntity>>().Remove(entity);
                        }
                        Logger.TLogInformation($"Уничтожена сущность:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                        //Post Remove Entity
                        bool postRemove = true;
                        var postRemoveActions = Activator.GetInstances<IEntityActionPostRemove<TEntity>>();
                        foreach (var action in postRemoveActions)
                        {
                            var actionResult = action.Invoke(ref entity, cacheOnly);
                            postRemove = postRemove && actionResult;
                            Logger.TLogWarning($"Действия после уничтожения сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                        }
                        if (postRemove)
                        {
                            Logger.TLogInformation($"Все действия после уничтожения сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                            return Save(entity, cacheOnly);
                        }
                        else
                        {
                            Logger.TLogError($"Не все действия после уничтожения сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                        }
                    }
                    else
                    {
                        Logger.TLogError($"Не все действия перед уничтожением сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    }
                }
                else
                {
                    Logger.TLogError($"Сущность не может быть уничтожена:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return null;
        }

        /// <summary>
        /// Уничтожить экземпляр сущности типа <typeparamref name="TEntity" />, удовлетворяющей предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Remove(Func<TEntity, bool> predicate, bool loadDeleted = false, bool cacheOnly = false)
        {
            return Remove(Get(predicate, loadDeleted), cacheOnly);
        }

        /// <summary>
        /// Уничтожить все сущности типа <typeparamref name="TEntity" />, удовлетворяющие предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Коллекция экземпляров отслеживаемых сущностей.
        /// </returns>
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

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity" /> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Update(TEntity entity, bool cacheOnly = false)
        {
            try
            {
                //Can Update Entity
                Logger.TLogInformation($"Запрос обновления сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                bool canUpdate = true;
                var canUpdateActions = Activator.GetInstances<IEntityActionCanUpdate<TEntity>>();
                foreach (var action in canUpdateActions)
                {
                    var actionResult = action.Invoke(ref entity, cacheOnly);
                    canUpdate = canUpdate && actionResult;
                    Logger.TLogWarning($"Проверка перед обновлением сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (canUpdate)
                {
                    //Pre Update Entity
                    Logger.TLogInformation($"Сущность может быть обновлена:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    bool preUpdate = true;
                    var preUpdateActions = Activator.GetInstances<IEntityActionPreUpdate<TEntity>>();
                    foreach (var action in preUpdateActions)
                    {
                        var actionResult = action.Invoke(ref entity, cacheOnly);
                        preUpdate = preUpdate && actionResult;
                        Logger.TLogWarning($"Действия перед обновлением сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (preUpdate)
                    {
                        //Update Entity
                        Logger.TLogInformation($"Все действия перед обновлением сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                        if (!cacheOnly)
                        {
                            entity = Storage.GetRepository<IEntityRepository<TEntity>>().Update(entity);
                        }
                        Logger.TLogInformation($"Обновлена сущность:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                        //Post Update Entity
                        bool postUpdate = true;
                        var postUpdateActions = Activator.GetInstances<IEntityActionPostUpdate<TEntity>>();
                        foreach (var action in postUpdateActions)
                        {
                            var actionResult = action.Invoke(ref entity, cacheOnly);
                            postUpdate = postUpdate && actionResult;
                            Logger.TLogWarning($"Действия после обновления сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                        }
                        if (postUpdate)
                        {
                            Logger.TLogInformation($"Все действия после обновления сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                            return Save(entity, cacheOnly);
                        }
                        else
                        {
                            Logger.TLogError($"Не все действия после обновления сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                        }
                    }
                    else
                    {
                        Logger.TLogError($"Не все действия перед обновлением сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    }
                }
                else
                {
                    Logger.TLogError($"Сущность не может быть обновлена:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return null;
        }

        /// <summary>
        /// Сохранить сущность в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns></returns>
        protected TEntity Save(TEntity entity, bool cacheOnly = false)
        {
            //Can Save Entity
            Logger.TLogInformation($"Попытка сохранить сущность:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
            bool canSave = true;
            var canSaveActions = Activator.GetInstances<IEntityActionCanSave<TEntity>>();
            foreach (var action in canSaveActions)
            {
                var actionResult = action.Invoke(ref entity, cacheOnly);
                canSave = canSave && actionResult;
                Logger.TLogWarning($"Проверка условий сохранения сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
            }

            if (canSave)
            {
                //Pre Save Entity
                Logger.TLogInformation($"Сущность может быть сохранена:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                bool preSave = true;
                var preSaveActions = Activator.GetInstances<IEntityActionPreSave<TEntity>>();
                foreach (var action in preSaveActions)
                {
                    var actionResult = action.Invoke(ref entity, cacheOnly);
                    preSave = preSave && actionResult;
                    Logger.TLogWarning($"Действия перед сохранением сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                }

                if (preSave)
                {
                    //Save Entity
                    Logger.TLogInformation($"Все действия перед сохранением сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                    if (!cacheOnly)
                    {
                        Storage.Save();
                    }
                    Logger.TLogWarning($"Сохранена сущность:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");

                    //Post Save Entity
                    bool postSave = true;
                    var postSaveActions = Activator.GetInstances<IEntityActionPostSave<TEntity>>();
                    foreach (var action in postSaveActions)
                    {
                        var actionResult = action.Invoke(ref entity, cacheOnly);
                        postSave = postSave && actionResult;
                        Logger.TLogWarning($"Действия после сохранения сущности:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]:\t{action.GetType().GetFullName()}\t{actionResult}");
                    }

                    if (postSave)
                    {
                        Logger.TLogInformation($"Все действия после сохранения сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    }
                    else
                    {
                        Logger.TLogError($"Не все действия после сохранения сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                    }
                }
                else
                {
                    Logger.TLogError($"Не все действия перед сохранением сущности успешно выполнены:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
                }
            }
            else
            {
                Logger.TLogError($"Сущность не может быть сохранена:\t{entity.GetType().GetFullName()}[{nameof(cacheOnly)}={cacheOnly}]");
            }
            return entity;
        }

        /// <summary>
        /// Получить все сущности типа <see cref="TargetType" />
        /// </summary>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>Коллекция экземпляров отслеживаемых сущностей.</returns>
        IEnumerable<object> IEntityManager.GetAll(bool loadDeleted)
        {
            return GetAll(loadDeleted);
        }
    }
}
