using ExtCore.Data.Abstractions;
using System;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Data.Extensions
{
    public static class GuidExtensions
    {
        public static User GetUser(this Guid uid, IStorage storage)
        {
            var user = storage.GetRepository<IUserRepository>().Get(uid);
            return user;
        }
    }
}
