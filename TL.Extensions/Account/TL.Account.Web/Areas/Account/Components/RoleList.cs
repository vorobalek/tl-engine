using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Web.Areas.Account.Components
{
    public class RoleList : ViewComponent
    {
        IStorage Storage { get; }

        public RoleList(IStorage storage)
        {
            Storage = storage;
        }

        public IViewComponentResult Invoke(IEnumerable<UserRole> userRoles)
        {
            foreach (var role in userRoles)
            {
                role.Role = Storage.GetRepository<IRoleRepository>().GetById(role.RoleId);
                role.Role.UserRoles = Storage.GetRepository<IUserRoleRepository>().GetByRoleId(role.Role.Id) as ICollection<UserRole>;

                foreach (var roleUser in role.Role.UserRoles)
                {
                    roleUser.User = Storage.GetRepository<IUserRepository>().GetById(roleUser.UserId);
                }

                role.Role.UserRoles = role.Role.UserRoles.OrderBy(p => p.User.Username);
            }

            return View(userRoles);
        }
    }
}
