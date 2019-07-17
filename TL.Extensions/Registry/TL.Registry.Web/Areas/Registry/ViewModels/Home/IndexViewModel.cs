using System;
using System.Collections.Generic;

namespace TL.Registry.Web.Areas.Registry.ViewModels.Home
{
    public class IndexViewModel
    {
        public class RegistryIndexViewModel
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime CreationDate { get; set; }
            public DateTime ModifiedDate { get; set; }
        }

        public IEnumerable<RegistryIndexViewModel> Registries { get; set; }
    }
}
