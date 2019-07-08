using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace bangbang
{
    class bangmin
    {
        static void Main(string[] args)
        {
            //取出G盘的xml文件
            // const string sr = "G:\\后台\\登录用户\\kystack.xml";
            // XElement element = XElement.Load(sr);
            #region 1||2||4.生成一个xml文件存到内存中
            //保存在本地G盘
            //Articlesethod.Articles();
            #endregion
            #region 5.删除id=12的评论
            //取出G盘的xml文件
            //string sr = "G:\\后台\\登录用户\\luckystack.xml";
            //XElement element = XElement.Load(sr);

            //var Articlesethods = from a in element.Descendants("conmment")

            //                     where
            //                     (string)a.Element("id").Value == "12"
            //                     select a;


            //foreach (var item in Articlesethods.ToList())//集合
            //{
            //    item.Remove();
            //}
            //Console.WriteLine(element);
            //Console.ReadKey();
            #endregion
            #region 6.改变id=2的article：idDraft=false，title=源栈培训：C#进阶-8：异步和并行
            //var Articlesethods = from a in element.Descendants("article")
            //                     where a.Element("id").Value == "2"
            //                     select a;

            //Console.WriteLine();
            //Articlesethods.ToList().ForEach(w=>   
            //{
            //    w.SetAttributeValue("idDraft", "false");
            //    w.SetElementValue("title", "源栈培训：C#进阶-8：异步和并行");
            //});

            //foreach (var item in Articlesethods)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            #endregion

            Articles textid = new Articles(1, "蒋先生", "脑袋快反光了", DateTime.Now);
            textid.articlesmethod();

            Guid.NewGuid();
        }

    }
}
