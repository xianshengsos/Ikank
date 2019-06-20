using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bzm.面向对象
{
    class Program
    {
       

        static void coll()
        {
         #region linq
            Article Getseet = new Article(new user { Name = "蒋先生", Id = 1 }, "标题1", "这是第一篇文章c#", Convert.ToDateTime("2019-1-8"));
            Article Getseet1 = new Article(new user { Name = "飞哥", Id = 2 }, "标题2", "这是第二篇文章c++", DateTime.Now);
            Article Getseet2 = new Article(new user { Name = "蒋先生", Id = 3 }, "标题3", "这是第三篇文章net", Convert.ToDateTime("2019-5-9"));
            Article Getseet3 = new Article(new user { Name = "飞哥", Id = 4 }, "标题4", "这是第四篇文章c#", Convert.ToDateTime("2018-4-4"));
            Article Getseet4 = new Article(new user { Name = "小鱼", Id = 5 }, "标题5", "这是第五篇文章.net", Convert.ToDateTime("2019-1-1"));
            Article Getseet5 = new Article(new user { Name = "小鱼", Id = 6 }, "标题6", "这是第六篇文章python", Convert.ToDateTime("2019-11-12"));

            List<Article> jym = new List<Article> { Getseet, Getseet1, Getseet2, Getseet3, Getseet4, Getseet5 };

            #region 查询全部信息

            //var seet = jym.Select(s=>s);
            //foreach (var i in seet)
            //{
            //    Console.WriteLine(i.Authors.Id+i.Authors.Id+i.Title+i.Body+i.Time);
            //}

            #endregion
            #region 1.找出“飞哥”发布的文章
            //var Seet = from j in jym  where j.Authors.Name == "飞哥" select j;

            //foreach (var item in Seet)
            //{
            //    Console.WriteLine("这是"+item.Authors.Name+"发布的文章："+item.Body);
            //}
            #endregion
            #region 2.找出2019年1月1日以后“小鱼”发布的文章
            //var Seet1 = from y in jym where y.Authors.Name == "小鱼" && y.Time > Convert.ToDateTime("2019-1-1") select y;
            //var Seet2 = jym.Where(y => y.Authors.Name == "小鱼" && y.Time > Convert.ToDateTime("2019-1-1"));

            //foreach (var i in Seet1)
            //{
            //    Console.WriteLine($"在2019年1月1日小鱼发布后的文章有：" + i.Body);
            //}

            #endregion
            #region 3.按发布时间升序/降序排列显示文章
            //var Seet2 = from m in jym orderby m.Time ascending select m;
            //var Seet3 = from mm in jym orderby mm.Time descending select mm;
            //foreach (var i in Seet2)
            //{
            //    Console.WriteLine("这是按时间的升序排序文章："+i.Body);
            //}
            //Console.WriteLine("\n");
            //foreach (var it in Seet3)
            //{
            //    Console.WriteLine("这是按时间的降序排序文章：" + it.Body);
            //}

            #endregion
            #region 4.统计每个用户各发布了多少篇文章
            #endregion
            #region 5.找出包含关键字“C#”或“.NET”的文章
            //var seet = jym.Where(j => j.Body.Contains("c#") || j.Body.Contains("net"));
            //foreach (var item in seet)
            //{
            //    Console.WriteLine($"{item.Authors.Name}：发布的文章里面包含关键字请看：{item.Body}");
            //}
            #endregion
            #region 6.找出评论数量最多的文章
            #endregion
            #endregion



           
            Console.ReadKey();
        }


    }
    #region 面向
    //
    public class user//作者的姓名
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    //父类继承最大
    public class Max
    {
        public user Authors;
        public string Title { get; set; }
        public string Body { get; set; }


        public Max(user au, string ti, string bo)
        {
            Authors = au;
            Title = ti;
            Body = bo;
        }
        public virtual void Comment()//评论
        {
            Console.WriteLine("**********");
        }

    }
    //求助
    public class Problem : Max, IPublish/*, IAgree,IDisagree*///求助
    {

        public Problem(user au) : base(au, " ", " ")
        {
        }
        public Problem(user au, string ti, string bo) : base(au, ti, bo)
        {
        }

        public override void Comment()//评论
        {
            Console.WriteLine("我是Suggest的评论");
        }

        public void problemFF()
        {
            Console.WriteLine();
        }

        public void Publish()
        {
            Console.WriteLine();
        }


    }
    //文章
    public class Article : Max, IAgree, IDisagree//文章
    {
         
        public DateTime Time;
        public Article(user au, string ti, string bo, DateTime me) : base(au, ti, bo)
        {
            Time = me;
        }


        //文章方法
        public void ArticleFF()
        {
            Console.WriteLine();
        }


        public void Agree()
        {
            Console.WriteLine("\n");
            int i = 9;
            Console.WriteLine($"点赞{i}次");
        }
        public void Disagree()
        {

            int o = 99;
            Console.WriteLine($"踩{o}");
        }

    }
    //意见建议
    public class Suggest : Max, IPublish/*,IAgree,IDisagree*///意见建议
    {
        public Suggest(user au, string bo) : base(au, null, bo)
        {
        }
        public override void Comment()//评论
        {
            Console.WriteLine("我是Suggest的评论");
        }
        public void suggestFF()
        {
            Console.WriteLine();
        }
        //发布方法
        public void Publish()
        {
            Console.WriteLine();
        }



    }
    //发布的接口
    internal interface IPublish
    {
        void Publish();//发布
    }
    //点赞的接口
    internal interface IAgree
    {
        void Agree();//点赞
    }
    //踩的接口
    internal interface IDisagree
    {
        void Disagree();//踩
    }
    //评论类
    public class Comment
    {
        public void speak() { }
    }
    #endregion
}
