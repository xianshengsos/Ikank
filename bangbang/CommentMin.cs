using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bangbang
{
    internal static class CommentMin
    {
        internal static void Commentyes(XmlElement ts, XmlDocument xxr)
        {

            //给comments添加子节点为true
            XmlElement comment = xxr.CreateElement("conmment");

            //给comment添加属性为true
            comment.SetAttribute("recommend", "true");
            ts.AppendChild(comment);

            //给comment添加属性id
            XmlElement commenid = xxr.CreateElement("id");
            commenid.InnerText = "12";
            comment.AppendChild(commenid);

            //给comment添加属性body
            XmlElement commentbody = xxr.CreateElement("body");
            commentbody.InnerText = "不错，赞！";
            comment.AppendChild(commentbody);

            //给comment添加属性authorId
            XmlElement commentauthorId = xxr.CreateElement("authorId");
            commentauthorId.InnerText = "2";
            comment.AppendChild(commentauthorId);
        }
        internal static void Commentnull(XmlElement st, XmlDocument rxx)
        {
            XmlElement comment = rxx.CreateElement("conmment");
            st.AppendChild(comment);

            //给comment添加属性id
            XmlElement commenid = rxx.CreateElement("id");
            commenid.InnerText = "14";
            comment.AppendChild(commenid);

            //给comment添加属性body
            XmlElement commentbody = rxx.CreateElement("body");
            commentbody.InnerText = "作业太难了";
            comment.AppendChild(commentbody);

            //给comment添加属性authorId
            XmlElement commentauthorId = rxx.CreateElement("authorId");
            commentauthorId.InnerText = "3";
            comment.AppendChild(commentauthorId);
        }

    }
}

