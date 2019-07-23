using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service;

namespace ASPNETRazor.Pages
{
    public class EscUserModel : PageModel
    {
        LoginModel _userServices = new LoginModel();
         
      
        public void OnGet()
        {
            ////_userServices.OnPost();
            
            ////string ad = "esc";
            ////HttpContext.Request.Cookies.Append(ad,)
        }
    }
}