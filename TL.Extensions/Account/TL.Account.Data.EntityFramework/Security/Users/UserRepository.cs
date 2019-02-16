using System;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.EntityFramework.Security.Users
{
    public class UserRepository : EntityComparableStoredRepository<User, Guid>, IUserRepository
    {
        public User GetByUsername(string username)
        {
            return Load(dbSet.SingleOrDefault(obj => obj.Username == username));
        }
    }
}
