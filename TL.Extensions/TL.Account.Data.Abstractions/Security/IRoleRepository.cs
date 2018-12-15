using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Secutiry;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IRoleRepository : IRepository
    {
        IEnumerable<Role> GetAll();

        Role GetById(Guid id);

        Role GetByName(string name);
    }
}
