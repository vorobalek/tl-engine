using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public IViewComponentResult Invoke(User user)
        {
            user.UserRoles = Storage.GetRepository<IUserRoleRepository>().GetByUserId(user.Id) as ICollection<UserRole>;

            foreach (var role in user.UserRoles)
            {
                role.Role = Storage.GetRepository<IRoleRepository>().GetById(role.RoleId);
                role.Role.UserRoles = Storage.GetRepository<IUserRoleRepository>().GetByRoleId(role.Role.Id) as ICollection<UserRole>;

                foreach (var roleUser in role.Role.UserRoles)
                {
                    roleUser.User = Storage.GetRepository<IUserRepository>().GetById(roleUser.UserId);
                }

                role.Role.UserRoles = role.Role.UserRoles.OrderBy(p => p.User.Username);
            }

            return View(user);
        }
    }
}
