using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using TUser = TL.Account.Data.Entities.Security.User;

namespace TL.Account.Data.Managers.User
{
    public interface IUserManager
    {
        Task<TUser> GetAcync(string username);

        Task<TUser> Get(Guid id);

        Task<TUser> CreateAsync(string username, string password, string description = null);

        Task<TUser> TryCreateAsync(string username, string password, string description = null);

        Task AuthenticateAsync(TUser user, HttpContext httpContext);
    }
}
