using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class IndexViewModel
    {
        public class InputModel
        {
            public Guid LinkId { get; set; }
        }

        [BindProperty]
        public InputModel BindModel { get; set; }

        public string OrderedBy { get; set; }
        public bool DescOrder { get; }

        public class LinkViewModel
        {
            public Guid Id { get; }
            public string Path { get; }
            public string OriginalPath { get; }
            public DateTime CreationDate { get; }
            public DateTime ModifiedDate { get; }
            public bool IsDeleted { get; }
            public LinkViewModel(Guid id, string path, string originalPath, DateTime creationDate, DateTime modifiedDate, bool isDeleted)
            {
                Id = id;
                Path = path;
                OriginalPath = originalPath;
                CreationDate = creationDate;
                ModifiedDate = modifiedDate;
                IsDeleted = isDeleted;
            }
        }

        public List<LinkViewModel> Links { get; }

        public IndexViewModel()
        {
            Links = new List<LinkViewModel>();
        }

        public IndexViewModel(IEnumerable<LinkViewModel> links, string orderedBy, bool desc)
        {
            OrderedBy = orderedBy;
            DescOrder = desc;
            Links = links.ToList();
        }
    }
}
