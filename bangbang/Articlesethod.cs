using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bangbang
{
    internal static class Articlesethod
    {

        internal static void Articles()
        {
            //1引用命名空间
            //2创建xml文档对象
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
            //4创建根结点   将根结点添加到文档中                      
            XmlElement articles = doc.CreateElement("articles");
            doc.AppendChild(articles);

            Articlemin.Articleno(doc, articles);
            Articlemin.Articleyes(doc, articles);

            string sr = "G:\\后台\\登录用户\\uckystack.xml";
            doc.Save(sr);

        }

    }
}
