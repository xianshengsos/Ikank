using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ASPNETRazor.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service;

namespace ASPNETRazor.Pages
{
    public class AboutModel : _LayoutModel
    {
      private const  string aboutIdKey = "aboutName";
        private UserService _userService;
        public AboutModel()
        {
            _userService = new UserService();
        }
        public  Release ReleaseTitle { get; set; }
        public string Message { get; set; }

        public override ActionResult OnGet()
        {
            ViewData["Title"] = "发布";
            base.OnGet();

            //ReleaseTitle.userName = Convert.ToString(ViewData["userName"]);
           
                



            return Page();
        }
        public ActionResult OnPost()
        {
           
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
           


            return Page();
        }
    }


    [BindProperties]
    public class Release
    {
        public string userName { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="请输入标题")]
        [MaxLength(10,ErrorMessage ="标题不得超出10个数字")]
        public string PostNameTitle { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="请输入发布内容")]
       
        public string PostContentsTitle { get; set; }
    }
}
