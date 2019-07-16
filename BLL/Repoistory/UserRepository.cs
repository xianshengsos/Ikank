using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
  public  class UserRepository:DbContext
    {
        public DbSet<User> _users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public User Get(int Id)
        {
            return new User();
        }
        public void Save(User user)
        {
            _users.Add(user);
            SaveChanges();
        }
        public void Save(Email email)
        {
            Emails.Add(email);
            SaveChanges();
        }
        public User GetBy(string name)
        {
            return null;
        }
    }
}
