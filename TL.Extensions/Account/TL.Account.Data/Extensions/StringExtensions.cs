using ExtCore.Data.Abstractions;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.Extensions
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
