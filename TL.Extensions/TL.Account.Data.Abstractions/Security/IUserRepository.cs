using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Secutiry;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IUserRepository : IRepository
    {
        IEnumerable<User> GetAll();

        User GetById(Guid id);

        User GetByUsername(string username);

        void Add(User user);

        ICollection<User> GetByRoleId(Guid id);
    }
}
