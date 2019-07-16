using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.Repoistory;
using Service;

namespace ASPNETRazor.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }
        public string Password { get; set; }
        public void OnGet()
        {
            
        }
        public void OnPost()
        {
            //BLL.User.Register(new BLL.User { Name = UserName, Password = Password });
            
            // new UserRepository().Save(new BLL.User { Name = UserName, Password = Password });
            BLL.User user = new BLL.User { Name = UserName, Password = Password };
            //方式一
            //new UserRepository().Save(user);
            new UserService().Register(user);
            //方式二
           
            //user.Register();
        }
    }
}