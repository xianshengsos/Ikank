using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL.Repoistory
{
  public  class UserRepository
    {
        private SQLContext _sqlContext;
        public UserRepository()
        {
            _sqlContext = new SQLContext();
        }

       
        public User Get(int Id)
        {
            return new User();
        }
        public User Save(User user)//添加sql
        {
            _sqlContext. _users.Add(user);
            _sqlContext.SaveChanges();
            return user;
        }
        public Email Save(Email email)
        {
            _sqlContext. Emails.Add(email);
            _sqlContext.SaveChanges();
            return email;
        }
        public User GetByName(string name)//查询sql
        {
            return _sqlContext._users.Where(u=>u.Name==name).SingleOrDefault();
        }

        public User GetById(int id)
        {
            return _sqlContext._users.Where(u => u.Id == id).SingleOrDefault();
        }

       
    }
}
