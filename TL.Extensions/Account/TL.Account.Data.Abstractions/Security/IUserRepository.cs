using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IUserRepository : IEntityRepository<User>
    {
        IEnumerable<User> GetAll();

        User GetById(Guid id);

        User GetByUsername(string username);

        void Add(User user);

        void Update(User user);
    }
}
