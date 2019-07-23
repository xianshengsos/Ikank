using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETRazor.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETRazor.Pages
{
    public class EscModel : _LayoutModel
    {
        public EscModel()
        {
        }

        public override ActionResult OnGet()
        {
            if (Request.Cookies["userId"] != null && Request.Cookies["auth"] != null)
            {
                Response.Cookies.Delete("userId");           
               Response.Cookies.Delete("auth");
            }
         return    RedirectToPage("Login");
        }
       
    }
}