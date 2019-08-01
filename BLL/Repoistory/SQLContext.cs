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
        public DbSet<Article> Articles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//连接sql
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bngbang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(options => {
                options.ToTable("Users")
                .Property(x => x.Name)
                .IsRequired();
            });
            modelBuilder.Entity<BlogToKeywords>()
                .HasKey(bk => new { bk.BlogId, bk.KeywordId });

            modelBuilder.Entity<BlogToKeywords>()
                .HasOne(bk => bk.Blog)
                .WithMany(b => b.keywords)
                .HasForeignKey(b => b.BlogId)
                ;

            modelBuilder.Entity<BlogToKeywords>()
                 .HasOne(bk => bk.Keyword)
                 .WithMany(b => b.Blogs)
                 .HasForeignKey(b => b.KeywordId)
                 ;
            modelBuilder.Entity<Article>()
                .HasDiscriminator(b => b.DiscriminatorType);
        }
    }
}
