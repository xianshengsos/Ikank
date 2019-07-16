using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using BLL.Repoistory;
using DAL;


namespace BLL
{
   
   public  class User
    {
        private UserRepository _userRepository;
        public User()
        {
            _userRepository = new UserRepository();
        }

        private static UserHelper _userHelper ;
        static User()
        {
            _userHelper = new UserHelper();
        }
         public int Id { get; set; }
         public string Name { get; set; }
         public string Password { get; set; }
        public User InvitedBy { get; set; }

     public string Email { get; set; }
        public string EmailCode { get; set; }
        public bool EmailHasvalidated { get; set; }

        public bool IsPasswordCalid()//密码的复杂度
        {
            return Password.Length>=4;
        }
        public void Register()
        {
            _userRepository.Save(this);
        }


        static string GetMd5Hash( string inp)
        {
            //1. 将字符串转换成byte[]
            //2. 进行MD5加密运算
            //using( MD5 md = MD5.Create())//using释放资源
            //{

            //}
            MD5 md = MD5.Create();
            byte[] data = md.ComputeHash(Encoding.UTF8.GetBytes(inp));

            //StringBuilder提高性能（其实也提高了可读性）
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }//密码加密






        public static void Register(User user)  //注册
        {
           _userHelper.Save(user.Name, user.Password);
        }
         public static bool IsNameDuplicated(string name)//判断用户名是否重复
        {
            return _userHelper.GetByName(name) != null;
        }

    }
}
