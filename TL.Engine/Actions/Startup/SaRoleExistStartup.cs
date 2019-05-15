using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Actions;

namespace TL.Engine.Actions.Startup
{
    public class SaRoleExistStartup : IStartupAction
    {
        public bool IsBlocker => false;

        public int Priority => 500;

        public string Description => "Проверка существования роли администратора.";

        IRoleManager RoleManager { get; }

        public SaRoleExistStartup(IRoleManager roleManager)
        {
            RoleManager = roleManager;
        }

        public IStartupActionResult Invoke()
        {
            if (RoleManager.Get(r => r.Name == Role.Sa.Name) is Role role)
            {
                return StartupActionResult.Good(description: "Роль администратора системы существует.");
            }

            return StartupActionResult.Bad("Fail", "В системе не существует роли системного администратора");
        }
    }
}
