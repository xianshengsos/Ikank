using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL.Repoistory;
using Service;
using System.ComponentModel.DataAnnotations;
using ASPNETRazor.Pages.Shared;

namespace ASPNETRazor.Pages
{

    [BindProperties]
    public class RegisterModel : _LayoutModel
    {
       public regis regist { get; set; }//封装成一个属性
        

        private UserService _userService;
        public RegisterModel()
        {
            _userService = new UserService();
        }
      
        public override ActionResult OnGet()
        {
            base.OnGet();
            return Page();
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _userService.Register(regist.UserNameL, regist.PasswordLtwo);
            
            return RedirectToPage("About");
        }
    }

    public class regis
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入账号")]
        [MaxLength(9, ErrorMessage = "请输入9位数内的账号字母")]

        public string UserNameL { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入密码")]
        [MaxLength(9, ErrorMessage = "请输入9位数内的密码字母")]
        [MinLength(4, ErrorMessage = "请输入大于4位数的密码字母")]
        public string PasswordL { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入二次密码")]

        [Compare("PasswordL", ErrorMessage = "2次输入密码不一致")]
        [MaxLength(9, ErrorMessage = "请输入9位数内的密码字母")]
        [MinLength(4, ErrorMessage = "请输入大于4位数的密码字母")]
        public string PasswordLtwo { get; set; }
    }
}