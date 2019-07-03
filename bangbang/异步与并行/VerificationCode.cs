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
        public static void Maincsa(/*string[] args*/)
        {
            Verificationmethod ve = new Verificationmethod(200,100);
            Thread tr = new Thread(ve.canvas);
            tr.Start();//打开
            Console.WriteLine($"当前托管线程：{tr.ManagedThreadId}");
            
            #region 11
            Task cans = new Task(ve.canvass);            
            cans.Start();
                     
            #endregion

        }
    }
}
