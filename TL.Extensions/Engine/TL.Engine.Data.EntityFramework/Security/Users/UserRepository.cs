using System;
using System.Linq;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.Security.Users
{
    public class UserRepository : EntityComparableRepository<User, Guid>, IUserRepository
    {
        public User GetByUsername(string username)
        {
            return Load(dbSet.FirstOrDefault(obj => obj.Username == username));
        }
    }
}
