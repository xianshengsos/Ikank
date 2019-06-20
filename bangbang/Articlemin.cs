using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bangbang
{
    internal static class Articlemin
    {
        internal static void Articleno(XmlDocument xt, XmlElement xy)
        {
            XmlElement article = xt.CreateElement("article");
            //设置该节点属性
            article.SetAttribute("isDraft", "false");
            xy.AppendChild(article);

            //给article添加子节点
            XmlElement id = xt.CreateElement("id");
            id.InnerText = "1";
            article.AppendChild(id);

            //给article添加子节点
            XmlElement title = xt.CreateElement("title");
            title.InnerText = "源栈培训：C#进阶-7：Linq to XML";
            article.AppendChild(title);

            //给article添加子节点
            XmlElement body = xt.CreateElement("body");
            body.InnerText = "什么是XML（EXtensible Markup Language）" +
                "是一种文本文件格式被设计用来传输和存储数据由：" +
                "标签和属性组成元素（节点），由元素组成“树状结构”必须有而且只能有一个根节点其他： ";
            article.AppendChild(body);

            //给article添加子节点
            XmlElement authorId = xt.CreateElement("authorId");
            authorId.InnerText = "1";
            article.AppendChild(authorId);

            //给article添加子节点
            XmlElement publishDate = xt.CreateElement("publishDate");
            publishDate.InnerText = Convert.ToString(DateTime.Now);
            article.AppendChild(publishDate);


            CommentMethod.Comment(xt, article);


        }
        internal static void Articleyes(XmlDocument xd, XmlElement xe)
        {
            //给ariticles添加子节点
            XmlElement ariticle = xd.CreateElement("article");
            //给添加的子节点加属性为true
            ariticle.SetAttribute("isDraft", "true");
            xe.AppendChild(ariticle);

            //给ariticlesariticle添加子节点id
            XmlElement id = xd.CreateElement("id");
            id.InnerText = "2";
            ariticle.AppendChild(id);

            //给ariticlesariticle添加子节点title
            XmlElement title = xd.CreateElement("title");
            title.InnerText = "源栈培训：C#进阶-6：异步和并行";
            ariticle.AppendChild(title);

            //给ariticlesariticle添加子节点authorid
            XmlElement authorid = xd.CreateElement("authorId");
            authorid.InnerText = "1";
            ariticle.AppendChild(authorid);
        }
    }
}
