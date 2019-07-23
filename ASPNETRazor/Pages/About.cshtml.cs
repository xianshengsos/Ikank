using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETRazor.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETRazor.Pages
{
    public class AboutModel : _LayoutModel
    {
        public string Message { get; set; }

        public override ActionResult OnGet()
        {
            base.OnGet();
            Message = "Your application description page.";
            return Page();
        }
    }
}
