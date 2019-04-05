using ExtCore.Data.Abstractions;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Data.Extensions
{
    public static class StringExtensions
    {
        public static User GetUser(this string username, IStorage storage)
        {
            var user = storage.GetRepository<IUserRepository>().GetByUsername(username);
            return user;
        }
    }
}
