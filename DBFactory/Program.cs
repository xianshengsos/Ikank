using System;
using Microsoft.EntityFrameworkCore;
using BLL.Repoistory;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DBFactory 
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFacade db = new SQLContext().Database;
            db.EnsureDeleted();//如果存在数据库，就删除
            //db.EnsureCreated();  //  什么和Migration冲突   别混合用
            db.Migrate();//返回上一层


            RegisterFactory.Create();
            NewFactory.Create();
            Console.ReadKey();
        }
    }
}
