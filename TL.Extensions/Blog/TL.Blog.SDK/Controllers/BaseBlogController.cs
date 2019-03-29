using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Blog.SDK.Controllers
{
    [Area("Blog")]
    public abstract class BaseBlogController : BaseController
    {
        public BaseBlogController(IStorage storage) : base(storage)
        {
        }
    }
}
