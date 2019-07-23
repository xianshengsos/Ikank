using System;
using Microsoft.EntityFrameworkCore;
using BLL.Repoistory;
namespace DBFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new SQLContext().Database.Migrate();//返回上一步
           
        }
    }
}
