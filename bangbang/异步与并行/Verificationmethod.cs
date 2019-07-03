using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bangbang.异步与并行
{
    internal class Verificationmethod//验证码方法
    {
        public const string ph = "G:\\后台\\登录用户";
                 
        internal Bitmap image;       
        internal Graphics g;      
        Random ran = new Random();
        internal Verificationmethod(int width,int height)
        {
            image = new Bitmap(width, height);
        }
        internal void canvas()
        {
            string file = ph + "\\images.gif";
            g = Graphics.FromImage(image);
            g.Clear(Color.AntiqueWhite);
            g.DrawLine(new Pen(Color.Khaki,10),
                       new Point(0,0),
                       new Point(100,50));
            g.DrawString(stringText(), new Font("宋体", 20),
                                      new SolidBrush(Color.DarkOrchid),
                                      new Point(35, 16));
            image.Save(file, ImageFormat.Jpeg);
        }      
        internal string stringText()//随机字符串
        {
            string[] present = new String[] { "先", "生", "A", "F", "百", "万", "红", "酒", "数", "组" };//文本                
            string str = present[ran.Next(0, present.Length)];
            string str1 = present[ran.Next(0, present.Length)];
            string str2 = present[ran.Next(0, present.Length)];
            string str3 = str + str1 + str2;
            return str3;
            
        }
        public void canvass()//画布
        {
            string file = ph + "\\mages.gif";
            g = Graphics.FromImage(image);
            g.Clear(Color.AntiqueWhite);
            Task line = Task.Run(() =>
                 {
                     g.DrawLine(new Pen(Color.Blue, 5),
                         new Point(5, 8),
                         new Point(180, 80));
                 });
            
          
               int Xwhdth=ran.Next(0,100);
                int Yheight = ran.Next(0, 100);
                
                Task spot = Task.Run(() =>
                     {
                         image.SetPixel(Xwhdth, Yheight, Color.Blue);
                        
                     });
                Console.WriteLine(spot.Id);
             
            image.Save(file, ImageFormat.Jpeg);
            
        }
    }
}