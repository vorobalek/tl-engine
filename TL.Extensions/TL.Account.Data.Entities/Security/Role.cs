using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace TL.Account.Data.Entities.Secutiry
{
    public class Role : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }
    }
}
