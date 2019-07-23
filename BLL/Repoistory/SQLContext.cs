using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
   public class SQLContext:DbContext
    {
        public DbSet<User> _users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Suggest> Suggests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//连接sql
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bngbang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
