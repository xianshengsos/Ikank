using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service;

namespace ASPNETRazor.Pages.Email
{
    public class ValidateModel : PageModel
    {
        private UserService _userService;
        public ValidateModel()
        {
            _userService = new UserService();
        }

        [BindProperty]//验证绑定
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            string validationUrlFormat = $"{Request.Scheme}://{Request.Host}/Email/Validate?code={0}&id={1}";
            _userService.SendvalidationEmail(EmailAddress,validationUrlFormat);
        }
    }
}