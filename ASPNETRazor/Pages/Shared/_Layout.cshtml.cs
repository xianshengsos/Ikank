using Microsoft.AspNetCore.Mvc.RazorPages;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETRazor.Pages.Shared
{
    public class _LayoutModel:PageModel
    {
        private const string userIdKey = "userId";
        private const string userAuth = "userAuth";
        private string userIdValue;
        private string userAuthValue;
        public virtual void OnGet()
        {
           
            if (HttpContext.Request.Cookies.TryGetValue(userIdKey, out userIdValue))
            {
              UserModel model= new UserService().GetById(Convert.ToInt32(userIdValue));
                if (model != null)
                {
                    if (Request.Cookies.TryGetValue(userAuth, out string userAuthValue))
                    {
                        if (userAuthValue == model.MD5Password)
                        {
                            ViewData["userName"] = model.Name;
                        }
                    }
                }
            }
          
        }
        public void OnPost()
        {

        }
    }
}
