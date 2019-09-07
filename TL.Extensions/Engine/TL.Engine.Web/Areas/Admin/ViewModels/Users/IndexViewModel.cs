using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TL.Engine.SDK.Services;

namespace TL.Engine.Web.Areas.Admin.ViewModels.Users
{
    public class IndexViewModel
    {
        public class CreateModel
        {
            [Required(ErrorMessage = "Не указан логин")]
            [Display(Name = "Логин")]
            public string Username { get; set; }
            public string Description { get; set; }

            [DataType(DataType.Password)]
            [Required(ErrorMessage = "Не указан пароль")]
            [Display(Name = "Пароль")]
            public string Password { get; set; }
            public string Roles { get; set; }
            public string Groups { get; set; }
        }

        [BindProperty]
        public CreateModel CreateUserModel { get; set; }

        public string Message { get; set; }

        public IndexViewModel()
        {

        }
    }
}
