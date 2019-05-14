using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Engine.SDK.Controllers;

namespace TL.Engine.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            string path = "/welcome";
            if (Request.Cookies["DefaultPage"] != null)
            {
                path = Request.Cookies["DefaultPage"];
            }
            else
            {
                Response.Cookies.Append("DefaultPage", path);
            }
            return Redirect(path);
        }

        [HttpPost]
        public IActionResult ChangePath(string path)
        {
            if (Request.Cookies["DefaultPage"] != null)
            {
                Response.Cookies.Delete("DefaultPage");
                Response.Cookies.Append("DefaultPage", path);
            }
            else
            {
                Response.Cookies.Append("DefaultPage", path);
            }
            return Redirect(path);
        }

        public IActionResult Exception()
        {
            throw new NotImplementedException("Test");
        }
    }
}