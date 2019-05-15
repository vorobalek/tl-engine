using System.Linq;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Actions;

namespace TL.Engine.Actions.Startup
{
    public class SaUserExistStartup : IStartupAction
    {
        public bool IsBlocker => false;

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
                var users = userRoles.Select(ur => UserManager.Get(ur.UserId));
                if (users.Count() > 0)
                {
                    return StartupActionResult.Good(description: $"Администратор(-ы) системы обнаружен(-ы):\r\n{string.Join("\r\n", users.Select(u => u.Username))}");
                }
            }
            return StartupActionResult.Bad("Fail", "В системе не зарегистрировано ни одного пользователя с привилегиями администратора");
        }
    }
}
