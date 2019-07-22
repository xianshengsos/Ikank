using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MD5Password { get; set; }
    }
}
