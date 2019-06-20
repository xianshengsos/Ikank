using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;


namespace draww
{
    class Program
    {

        static void Main(string[] args)
        {
            string file = "G:\\后台\\登录用户\\jym.gif";
            Text p = new Text();
            Bitmap image = new Bitmap(222, 111);
            Graphics i = Graphics.FromImage(image);            
            i.Clear(p.Backgroundcolor(i));
            i.DrawString(p.Characterst(), p.Typeface(), p.Fontcolort(), new Point(25, 14));//画
            p.Linecolor(i);
            p.Countingtpoints(image);
            image.Save(file, ImageFormat.Jpeg);
            Console.WriteLine("*********生成成功*********");

        }
    }
}