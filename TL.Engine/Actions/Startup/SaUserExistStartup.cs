using System.Linq;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Actions;

namespace TL.Engine.Actions.Startup
{
    public class SaUserExistStartup : IStartupAction
    {
        public int Priority => 600;

        public string Description => "Проверка существования администратора.";

        IUserManager UserManager { get; }

        IUserRoleManager UserRoleManager { get; }

        public SaUserExistStartup(IUserManager userManager, IUserRoleManager userRoleManager)
        {
            UserManager = userManager;
            UserRoleManager = userRoleManager;
        }

        public IStartupActionResult Invoke()
        {
            var userRoles = UserRoleManager.GetAll(ur => ur.RoleId == Role.Sa.Id);
            if (userRoles.Count() > 0)
            {
                var users = userRoles.Select(ur => UserManager.GetByKey(ur.UserId));
                if (users.Count() > 0)
                {
                    return StartupActionResult.Good(description: Description);
                }
            }
            return StartupActionResult.Broken("Fail", "В системе не зарегистрировано ни одного пользователя с привилегиями администратора");
        }
    }
}
