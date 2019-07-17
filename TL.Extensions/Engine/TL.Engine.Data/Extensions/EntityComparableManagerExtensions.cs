using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Extensions
{
    public static class EntityComparableManagerExtensions
    {
        public static IEnumerable<TEntity> GetAllowedForUser<TEntity, TKey>(this IEntityComparableManager<TEntity, TKey> manager, User user)
            where TEntity : class, IEntityComparable<TKey>
            where TKey : IComparable
        {
            return manager.GetAllowedFor<User, Guid>(user);
        }

        public static IEnumerable<TEntity> GetAllowedForGroup<TEntity, TKey>(this IEntityComparableManager<TEntity, TKey> manager, Group group)
            where TEntity : class, IEntityComparable<TKey>
            where TKey : IComparable
        {
            return manager.GetAllowedFor<Group, Guid>(group);
        }

        public static IEnumerable<TEntity> GetAllowedForRole<TEntity, TKey>(this IEntityComparableManager<TEntity, TKey> manager, Role role)
            where TEntity : class, IEntityComparable<TKey>
            where TKey : IComparable
        {
            return manager.GetAllowedFor<Role, Guid>(role);
        }

        public static IEnumerable<TEntity> GetAllowedForUsers<TEntity, TKey>(this IEntityComparableManager<TEntity, TKey> manager, IEnumerable<User> users)
            where TEntity : class, IEntityComparable<TKey>
            where TKey : IComparable
        {
            return users.SelectMany(user => manager.GetAllowedForUser(user));
        }

        public static IEnumerable<TEntity> GetAllowedForGroups<TEntity, TKey>(this IEntityComparableManager<TEntity, TKey> manager, IEnumerable<Group> groups)
            where TEntity : class, IEntityComparable<TKey>
            where TKey : IComparable
        {
            return groups.SelectMany(group => manager.GetAllowedForGroup(group));
        }

        public static IEnumerable<TEntity> GetAllowedForRoles<TEntity, TKey>(this IEntityComparableManager<TEntity, TKey> manager, IEnumerable<Role> roles)
            where TEntity : class, IEntityComparable<TKey>
            where TKey : IComparable
        {
            return roles.SelectMany(role => manager.GetAllowedForRole(role));
        }
    }
}
