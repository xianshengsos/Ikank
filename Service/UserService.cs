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
        public int Id { get; set; }
        public string MD5Password { get; set; }
        public User Register(string UserName, string Password)
        {
               string Passwords=User.GetMd5Hash(Password);
            User user = new User { Name = UserName, Password = Passwords };
            
            _userRepository.Save(user);
            return user;
        }

        public UserModel GetById(int id)
        {
            User user = _userRepository.GetById(id);
            if (user == null)
            {
                return null;
            }
            else
            {
                UserModel model = new UserModel();

                model.Id = user.Id;
                model.Name = user.Name;
                model.MD5Password = user.Password;

                return model;
            }
        }

        public bool HasExist(string username)
        {
            return _userRepository.GetByName(username) != null;
        }

        public void SendvalidationEmail(string emailAddress, string validationUrlFormat)
        {
            Email email = new Email { Address = emailAddress };

            _userRepository.Save(email);
            string validationUrl = string.Format(validationUrlFormat, email.Id, email.ValidationCode);

            //$"{host}/Email/Validate?code={ValidationCode}&id={Id}";
        }

        public UserModel GetLogInfo(string userName)
        {
            User user = _userRepository.GetByName(userName);
            if (user == null)
            {
                return null;
            }
            else
            {
                UserModel model = new UserModel();

                model.Id = user.Id;
                model.Name = user.Name;
                model.MD5Password = user.Password;

                return model;
            }
        }
        public bool PasswordCorrect(string rawPassword, string MD5Password)
        {
            return User.GetMd5Hash(rawPassword) == MD5Password;
        }

    }
}
