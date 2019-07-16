using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace DAL
{
   
  public  class UserHelper
    {
        private static DataTable _users;
        public UserHelper()
        {
            _users = new DataTable();
        }
       //在sql查找用户ID找到返回NULL或者用户ID
        public int? GetByName(string username)
        {
             
            return null;
        }

        public void Save(string name, string password)
        {
            
        }
    }
}
