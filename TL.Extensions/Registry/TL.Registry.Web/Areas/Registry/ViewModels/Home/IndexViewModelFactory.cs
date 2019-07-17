using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Extensions;
using TL.Registry.Data.Managers;

namespace TL.Registry.Web.Areas.Registry.ViewModels.Home
{
    public class IndexViewModelFactory
    {
        public IndexViewModel Empty()
        {
            return new IndexViewModel()
            {
                Registries = new List<IndexViewModel.RegistryIndexViewModel>()
            };
        }

        public IndexViewModel Create(IEnumerable<User> users, IEnumerable<Group> groups, IEnumerable<Role> roles, IRegistryManager registryManager)
        {
            var registries = new HashSet<IndexViewModel.RegistryIndexViewModel>();
            var usersAllowed = registryManager.GetAllowedForUsers(users);
            var groupsAllowed = registryManager.GetAllowedForGroups(groups);
            var rolesAllowed = registryManager.GetAllowedForRoles(roles);
            var all = usersAllowed.Concat(groupsAllowed).Concat(rolesAllowed).Distinct();

            foreach (var registry in all)
            {
                registries.Add(new IndexViewModel.RegistryIndexViewModel()
                {
                    Id = registry.Id,
                    CreationDate = registry.CreationDate,
                    ModifiedDate = registry.ModifiedDate,
                    Name = registry.Name,
                    Description = registry.Description,
                });
            }

            return new IndexViewModel()
            {
                Registries = registries
            };
        }
    }
}
