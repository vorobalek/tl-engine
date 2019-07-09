using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    /// <summary>
    /// Абстрактная реализация репозитория элементарных сущностей <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <seealso cref="ExtCore.Data.EntityFramework.RepositoryBase{TEntity}" />
    /// <seealso cref="IEntityRepository{TEntity}" />
    public abstract class EntityRepository<TEntity> : RepositoryBase<TEntity>, IEntityRepository<TEntity> where TEntity : class, IEntity
    {
        public virtual TEntity Add(TEntity entity)
        {
            if (entity != null)
            {
                if (entity is IEntityStored entityStored)
                {
                    entityStored.CreationDate = DateTime.Now.ToUniversalTime();
                    entityStored.ModifiedDate = DateTime.Now.ToUniversalTime();
                    entity = entityStored as TEntity;
                }
                return Load(dbSet.Add(entity).Entity);
            }
            else
            {
                return null;
            }
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
            return Load(dbSet.SingleOrDefault(e => predicate(e) && (loadDeleted || !loadDeleted && !e.IsDeleted)));
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
            return dbSet.Where(e => predicate(e) && (loadDeleted || !loadDeleted && !e.IsDeleted)).Select(e => Load(e));
        }

        /// <summary>
        /// Уничтожить экземпляр сущности типа <typeparamref name="TEntity" /> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public TEntity Remove(TEntity entity)
        {
            return Load(dbSet.Remove(entity).Entity);
        }

        /// <summary>
        /// Уничтожить экземпляр сущности типа <typeparamref name="TEntity" />, удовлетворяющей предикату.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public TEntity Remove(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            return Remove(dbSet.SingleOrDefault(e => predicate(e) && (loadDeleted || !loadDeleted && !e.IsDeleted)));
        }

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity" /> в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Update(TEntity entity)
        {
            if (entity != null)
            {
                if (entity is IEntityStored entityStored)
                {
                    entityStored.ModifiedDate = DateTime.Now.ToUniversalTime();
                    entity = entityStored as TEntity;
                }
                return Load(dbSet.Update(entity).Entity);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Получить и отслеживать сущность из хранилища.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Load(TEntity entity)
        {
            try
            {
                storageContext.Entry(entity).References.ToList().ForEach(prop => prop.Load());
                storageContext.Entry(entity).Collections.ToList().ForEach(prop => prop.Load());
            }
            catch { }

            return entity;
        }
    }
}
