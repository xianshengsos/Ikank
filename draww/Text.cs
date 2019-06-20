using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
namespace draww
{
    public class Text
    {

        public const int c = 1;


        Random ran = new Random();

        public string Characterst()//汉字
        {
            try
            {
                string[] present = new String[] { "先", "生", "A", "F", "百", "万", "红", "酒", "数", "组" };//文本                
                string str = present[ran.Next(0, present.Length)];
                string str1 = present[ran.Next(0, present.Length)];
                string str2 = present[ran.Next(0, present.Length)];
                String str3 = str + str1 + str2;
                return str3;
            }
            catch (Exception eh)
            {

                throw eh;
            }




        }//汉字     

        

        public void Countingtpoints(Bitmap imag)//数点
        {
            try
            {
                int a, b;
                for (int n = 0; n < 201; n++)
                {
                    a = ran.Next(0, 200);
                    b = ran.Next(0, 100);
                    imag.SetPixel(a, b, Color.DarkBlue);
                }
            }
            catch (Exception es)
            {

                throw es;
            }


        }//数点


        public List<Color> Linecolor(Graphics g)//线条颜色
        {

            Color[] cr = new Color[] { Color.AliceBlue, Color.AntiqueWhite,
                Color.Beige, Color.Aquamarine, Color.Azure, Color.Crimson, Color.Chartreuse };
            Color cc, bb;
            cc = cr[ran.Next(0, cr.Length)];
            bb = cr[ran.Next(0, cr.Length)];
            List<Color> lc = new List<Color>() { cc, bb };
            try
            {

                if (cc != bb)
                {

                    Linecolors(lc, g);
                    //g.DrawLine(new Pen(cc, c1), new Point(2, 5), new Point(210, 80));
                    //g.DrawLine(new Pen(bb, c2), new Point(10, 2), new Point(80, 210));

                }
                else
                {
                    File.AppendAllText("G:\\后台\\登录用户\\jym.log", $"{DateTime.Now}:颜色随机出现异常" + Environment.NewLine);
                }

            }
            catch (Exception ey)
            {

                throw;
            }



            return lc;



        }//颜色



        public Font Typeface()//字体
        {
            Font fo = new Font("SketchFlow Print", 30);//字体 
            return fo;
        }//字体


        public Brush Fontcolort()//字体颜色
        {
            SolidBrush sb = new SolidBrush(Color.Goldenrod);//字体颜色
            return sb;
        }//字体颜色


        public Color Backgroundcolor(Graphics gp)//背景颜色
        {
            try
            {
                Color[] co = new Color[] {Color.DarkGreen, Color.AntiqueWhite,
                Color.Aqua, Color.BurlyWood, Color.Azure, Color.Crimson, Color.Chartreuse };
                Color gg = co[ran.Next(0, co.Length)];
                return gg;
            }
            catch (Exception eb)
            {

                throw eb;
            }


        }//背景颜色

        public void Linecolors(List<Color> lcs, Graphics gr)
        {
            const int c1 = 8;//cc线条粗细
            const int c2 = 7;//bb的线条粗细
            int x, y, width, height;
            
                x = ran.Next(0, 200);
                y = ran.Next(0, 200);
                width = ran.Next(0, 200);
                height = ran.Next(0, 200);
            

            Color cc = lcs[0];
            Color bb = lcs[1];
            try
            {
                if (x != width || y != height)
                {

                    gr.DrawLine(new Pen(cc, c2), new Point(x, 8), new Point(80, height));
                    gr.DrawLine(new Pen(bb, c1), new Point(50, y), new Point(width, 100));
                    
                }
                else
                {
                    throw new Exception("线条之间坐标不能一样");
                }
            }
            catch (Exception)
            {

                throw;
            }

            gr.DrawLine(new Pen(cc, c1), new Point(2, 5), new Point(210, 80));
        }
        public void Calculation()
        {


        }
    }
}
