using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using TUser = TL.Account.Data.Entities.Security.User;

namespace TL.Account.Data.Managers.User
{
    public interface IUserManager
    {
        Task<TUser> GetAsync(Guid id);

        Task<TUser> GetAsync(string username);

        Task<TUser> CreateAsync(string username, string password, string description = null);

        Task<TUser> GetOrCreateAsync(string username, string password = null, string description = null);

        Task AuthenticateAsync(TUser user, HttpContext httpContext);
    }
}
