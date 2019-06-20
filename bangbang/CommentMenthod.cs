using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace bangbang
{
    internal static class CommentMethod
    {
        internal static void Comment(XmlDocument xr, XmlElement ar)
        {
            XmlElement comments = xr.CreateElement("comments");
            ar.AppendChild(comments);

            CommentMin.Commentyes(comments, xr);
            CommentMin.Commentnull(comments, xr);

        }
    }
}
