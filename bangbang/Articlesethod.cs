using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace bangbang
{
    internal static class Articlesethod
    {
        internal const string s = "G:\\后台\\登录用户";
        internal static void Articles()
        {
            
            //创建xml文档对象
            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //创建根结点   将根结点添加到文档中                      
            XmlElement articles = doc.CreateElement("articles");
            doc.AppendChild(articles);

           
            Articlemin.Articleno(doc, articles);
            Articlemin.Articleyes(doc, articles);

            string sr =s+ "\\kystack.xml";
            doc.Save(sr);
            
        }
        
    }
   
    internal class Articles
    {
        internal const string s = "G:\\后台\\登录用户";
        internal int id;
        internal string name;
        internal string pssword;
        internal string textarticles;
        internal DateTime time;
        internal Articles(int id,string name,string textarticles, DateTime time)
        {
            this.id = id;
            this.name = name;
            this.textarticles = textarticles;
            this.time = time;
        }
        internal void articlesmethod()
        {
            //创建xml文件对象
            XmlDocument xdt = new XmlDocument();
            XmlDeclaration d = xdt.CreateXmlDeclaration("1.0", "utf-8", null);
            xdt.AppendChild(d);
            //创建根结点
            XmlElement arti = xdt.CreateElement("Articles");
            xdt.AppendChild(arti);
            //创建子节点

            XmlElement ariticle = xdt.CreateElement("article");
            //给添加的子节点加属性为true
            ariticle.SetAttribute("isDraft", "true");
            arti.AppendChild(ariticle);

            //给ariticlesariticle添加子节点id
            XmlElement Id = xdt.CreateElement("id");
            //字段的id
            Id.InnerText =Convert.ToString(id);
            ariticle.AppendChild(Id);

            //给ariticlesariticle添加子节点authorid
            XmlElement Authorname = xdt.CreateElement("Authorname");
            Authorname.InnerText = name;
            ariticle.AppendChild(Authorname);

            //给ariticlesariticle添加子节点title
            XmlElement text = xdt.CreateElement("text");
            //写得文章
            text.InnerText = textarticles;
            ariticle.AppendChild(text);
            //
            XmlElement lasting = xdt.CreateElement("time");
            lasting.InnerText = "文章发表于" + time;
            ariticle.AppendChild(lasting);

            string file = s + "\\xmlj.xml";
            xdt.Save(file);
        }

    }
}
