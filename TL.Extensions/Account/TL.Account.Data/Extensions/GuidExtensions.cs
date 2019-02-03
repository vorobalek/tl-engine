using ExtCore.Data.Abstractions;
using System;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.Extensions
{
    public static class GuidExtensions
    {
        public static User GetUser(this Guid uid, IStorage storage)
        {
            var user = storage.GetRepository<IUserRepository>().GetById(uid);
            return user;
        }
    }
}
