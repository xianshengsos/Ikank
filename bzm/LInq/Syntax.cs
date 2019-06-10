using System;
using System.Collections.Generic;
using System.Text;

namespace bzm.LInq
{
    class Syntax
    {

        static void call()
        {
            #region 案列
            // var man = new[]
            //{
            //        new{name="李药师",age="19",sex="男"},
            //        new{name="王铁柱",age="19",sex="女"},
            //        new{name="巢昱清",age="19",sex="女"},
            //        new{name="张德培",age="24",sex="男"},
            //    };

            // var jym = from j in man group j by j.age;
            // //into y select new
            // //{

            // //    da = y.Key,
            // //    asd = y.Count()
            // //};

            // foreach (var p in jym)
            // {


            //     Console.WriteLine(p.Key.GetType());

            // }

            // Console.WriteLine();

            // Console.ReadKey();
            #endregion

            Article Getseet = new Article { Namep = new authorr { Name = "蒋先生", Id = 1 }, Essay = "这是第一篇文章", Time = Convert.ToDateTime("2019-1-8") };
            Article Getseet2 = new Article { Namep = new authorr { Name = "蒋大大", Id = 2 }, Essay = "这是第二篇文章", Time = DateTime.Now };
            Article Getseet3 = new Article { Namep = new authorr { Name = "飞哥", Id = 3 }, Essay = "这是飞哥写的文章", Time = Convert.ToDateTime("2017-12-31") };
            Article Getseet4 = new Article { Namep = new authorr { Name = "小鱼", Id = 4 }, Essay = "这一篇文章是假的", Time = Convert.ToDateTime("2019-1-1") };
            Article Getseet5 = new Article { Namep = new authorr { Name = "蒋百万", Id = 5 }, Essay = "这是一个年薪百万的大佬", Time = Convert.ToDateTime("2018-7-27") };
            Article Getseet6 = new Article { Namep = new authorr { Name = "小鱼", Id = 6 }, Essay = "这一篇文章是小蒋的", Time = Convert.ToDateTime("2019-1-2") };

            List<Article> jym = new List<Article> { Getseet, Getseet5, Getseet2, Getseet4, Getseet3 };
            #region 查询飞哥发布的文章
            //var jymjym = from j in jym
            //             where j.Namep.Name == "飞哥"
            //             select j;

            //foreach (var item in jymjym)
            //{
            //    Console.WriteLine("这是 " + item.Namep.Name + " 编号为 " + item.Namep.Id + " 的发布一篇文章:" + item.Essay);

            //}
            //Console.ReadKey();


            #endregion
            #region 找出2019年1月1日以后“小鱼”发布的文章

            #endregion
        }
    }

    public class authorr
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class Article
    {
        public authorr Namep;
        public string Essay;
        public DateTime Time;
    }



}
