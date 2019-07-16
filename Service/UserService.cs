using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using BLL.Repoistory;


namespace Service
{
   public class UserService
    {
        private UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        //public void Register(User user)
        //{
        //    _userRepository.Save(user);
        //}

        public void SendvalidationEmail(string emailAddress,string validationUrlFormat)
        {
            Email email = new Email { Address = emailAddress };
            
            _userRepository.Save(email);
            string validationUrl = string.Format(validationUrlFormat, email.Id, email.ValidationCode);
                
                //$"{host}/Email/Validate?code={ValidationCode}&id={Id}";
        }
    }
}
