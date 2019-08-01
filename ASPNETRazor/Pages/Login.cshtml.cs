using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Threading.Tasks;
using ASPNETRazor.Pages.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Service;

namespace ASPNETRazor.Pages
{
    [BindProperties]
    public class LoginModel : _LayoutModel
    {
        private UserService _userService;


        public LoginModel()
        {
            _userService = new UserService();
        } 

        [Required(AllowEmptyStrings = false, ErrorMessage = "账户必须填写")]
        [MaxLength(9, ErrorMessage = "最大长度不能超出9位数")]

        public string UserName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "密码必须填写")]
        [MaxLength(9, ErrorMessage = "最大长度不能超过9位数")]
        [MinLength(4, ErrorMessage = "最小的长度不能少于4位数")]
        public string Password { get; set; }
        public override ActionResult OnGet()
        {
            ViewData["Title"] = "登录";
            base.OnGet();
            return Page();
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            UserModel model = _userService.GetLogInfo(UserName);//取已有的账号


            if (model == null)
            {
                ModelState.AddModelError("UserName", "* 用户名不存在");
                return Page();
            }
            if (!_userService.PasswordCorrect(Password, model.MD5Password))//比较账号
            {
                ModelState.AddModelError("Password", "* 用户名或密码错误");
                return Page();
            }
            string uu = "userId";
            Response.Cookies.Append(uu, model.Id.ToString(),
                new CookieOptions
                {
                    //Domain定义域
                    //Path = "/Login",
                    Expires = DateTime.Now.AddDays(1),
                    IsEssential = true
                });
            string ss = "auth";
            Response.Cookies.Append(ss, model.MD5Password,
                new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(1),
                    IsEssential = true
                });
            //Session 获取
            HttpContext.Session.SetString("UserName", JsonConvert.SerializeObject(model));
            return RedirectToPage("About");
        }
        
    }
}