using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Secutiry;

namespace TL.Account.Data.EntityFramework.Security.Users
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public void Add(User user)
        {
            dbSet.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return dbSet.OrderBy(obj => obj.Username);
        }

        public User GetById(Guid id)
        {
            return dbSet.FirstOrDefault(obj => obj.Id == id);
        }

        public User GetByUsername(string username)
        {
            return dbSet.FirstOrDefault(obj => obj.Username == username);
        }
    }
}
