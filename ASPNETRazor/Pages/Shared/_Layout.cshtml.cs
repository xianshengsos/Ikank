﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Newtonsoft.Json;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace ASPNETRazor.Pages.Shared
{
    public class _LayoutModel:PageModel
    {
        private const string userIdKey = "userId";
        private const string userAuth = "auth";
      
      
        public virtual ActionResult OnGet()
        {
            //Session登录状态
            //ViewData["ppp"]=HttpContext.Session.GetString("UserName");


            string userIdValue;
            if (HttpContext.Request.Cookies.TryGetValue(userIdKey, out userIdValue))
            {
                UserModel model = new UserService().GetById(Convert.ToInt32(userIdValue));

                if (model != null)
                {
                    if (HttpContext.Request.Cookies.TryGetValue(userAuth, out string userAuthValue))
                    {
                        if (userAuthValue == model.MD5Password)
                        {
                            ViewData["userName"] = model.Name;

                        }
                        else
                        {
                            Response.Cookies.Delete(userIdKey);
                            Response.Cookies.Delete(userAuth);
                        }
                    }
                }
            }
            return Page();
        }
      


    }
}
