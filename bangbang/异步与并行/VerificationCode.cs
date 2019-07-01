using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bangbang.异步与并行
{
    class VerificationCode//验证码开始
    {
        public const string ph = "G:\\后台\\登录用户";
        public static void Main(string[] args)
        {
            Verificationmethod ve = new Verificationmethod(200,100);           
            Thread tr = new Thread( ve.canvas);
            tr.Start();//打开
            #region 11
            //Task cans = Task.Run(
            //// ve.canvas
            //() =>
            // {
            //     string file = "G:\\后台\\登录用户\\mages.gif";
            //     Bitmap bi = new Bitmap(200, 100);
            //     Graphics gr = Graphics.FromImage(bi);
            //     gr.Clear(Color.Aquamarine);

            //     Task line = Task.Run(() =>
            //     {
            //         gr.DrawLine(new Pen(Color.Blue, 5),
            //             new Point(5, 8),
            //             new Point(180, 80));
            //     });

            //     Task spot = Task.Run(() =>
            //     {
            //         bi.SetPixel(45, 90, Color.Blue);

            //     });

            //     bi.Save(file, ImageFormat.Jpeg);

            // }
            //);
#endregion

        }
    }
}
