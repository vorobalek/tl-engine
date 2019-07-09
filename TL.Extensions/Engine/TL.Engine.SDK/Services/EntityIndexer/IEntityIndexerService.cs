using System.Collections.Generic;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Engine.SDK.Services
{
    /// <summary>
    /// Интерфейс сервиса полнотекстовой индексации сущностей.
    /// </summary>
    public interface IEntityIndexerService
    {
        /// <summary>
        /// Найти все сущности, содержащую хоты бы в одном из индексируемых строковых полей заданную подстроку.
        /// </summary>
        /// <param name="query">Поисковый запрос.</param>
        /// <param name="count">Максимальное количество возвращаемых объектов.</param>
        /// <returns></returns>
        [PrivateApi]
        IEnumerable<object> Find(string query, int count = 0);

        /// <summary>
        /// Найти все экземпляры сущности <typeparamref name="TEntity"/>, содержащую хоты бы в одном из индексируемых строковых полей заданную подстроку.
        /// </summary>
        /// <typeparam name="TEntity">Тип искомой сущности.</typeparam>
        /// <param name="query">Поисковый запрос.</param>
        /// <param name="count">Максимальное количество возвращаемых объектов.</param>
        /// <returns></returns>
        IEnumerable<object> Find<TEntity>(string query, int count = 0);

        /// <summary>
        /// Добавить экземпляр сущности <typeparamref name="TEntity"/> в индекс.
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности.</typeparam>
        /// <param name="entity">Экземпляр сущности.</param>
        /// <returns></returns>
        bool Add<TEntity>(TEntity entity);

        /// <summary>
        /// Обновить экземпляр сущности <typeparamref name="TEntity"/> в индексе.
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности.</typeparam>
        /// <param name="oldEntity">Старый экземпляр сущности.</param>
        /// <param name="newEntity">Новый экземпляр сущности.</param>
        /// <returns></returns>
        bool Update<TEntity>(TEntity oldEntity, TEntity newEntity);

        /// <summary>
        /// Удалить экземпляр сущности <typeparamref name="TEntity"/> из индекса.
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности.</typeparam>
        /// <param name="entity">Экземпляр сущности.</param>
        /// <returns></returns>
        bool Remove<TEntity>(TEntity entity);

        /// <summary>
        /// Сбросить сервис и инициализировать заново.
        /// </summary>
        [PrivateApi]
        void Reset();
    }
}