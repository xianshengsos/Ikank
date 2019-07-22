using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        public User Save(User user)//添加sql
        {
            _users.Add(user);
            SaveChanges();
            return user;
        }
        public Email Save(Email email)
        {
            Emails.Add(email);
            SaveChanges();
            return email;
        }
        public User GetByName(string name)//查询sql
        {
            return _users.Where(u=>u.Name==name).SingleOrDefault();
        }

        public User GetById(int id)
        {
            return _users.Where(u => u.Id == id).SingleOrDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//连接sql
        {
            string connectionString =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bngbang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
