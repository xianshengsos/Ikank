using System;
using System.Collections;

namespace bzm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数值转换
            //int q = 2;
            //int w = 6;
            //int z=0;
            //z = q;.
            //q = w;
            //w = z;
            //Console.WriteLine($"q={q},w={w}");
            //Console.ReadKey();

            #endregion
            #region 猜数字游戏
            //Console.WriteLine("**********欢迎来到猜数字游戏**************");
            //Console.WriteLine("请输入1到999之间的数字");
            //Random w = new Random();
            //int q=w.Next(1, 999);
            ////int e = Convert.ToInt32(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());           

            //    for (int i = 10; i > 0; i--)
            //    {
            //        if (e <= 0 || e > 999)
            //        {
            //            Console.WriteLine("输入超出规定数字,请重新输入");
            //            Console.WriteLine($"还剩下{i-1}次");
            //            e = int.Parse(Console.ReadLine());
            //        }
            //        else
            //        {
            //            if (e == q)
            //            {
            //                Console.WriteLine($"恭喜你在{10-i}次答对,随机数是{q}");
            //            }
            //            else if (e > q)
            //            {
            //                Console.WriteLine($"输入的数值太大了，请再试一次");
            //                Console.WriteLine($"你目前还有{i-1}机会");
            //                e = Convert.ToInt32(Console.ReadLine());
            //            }
            //            else if (e < q)
            //            {
            //                Console.WriteLine($"输入的数值太小了，请在试一次");
            //                Console.WriteLine($"你目前还有{i-1}机会");
            //                e = int.Parse(Console.ReadLine());

            //            }
            //        }
            //    }       
            //Console.ReadKey();
            #endregion
            #region 冒泡排序
            //int q = 0;
            //int[] w = new int[] {806,456,12,1,354,4863,354,48,4566,353,882 };
            //for (int i = 0; i < w.Length-1; i++)//计算一共要循环几次   w.Length-1从0开始计算一共次数 
            //{
            //    for (int j = 0;  j< w.Length-1-i; j++)//数值一共比较几次 w.Length-1-i还剩的数

            //    {
            //        if (w[j] > w[j + 1])//升序
            //        {
            //            q = w[j];
            //            w[j] = w[j + 1];
            //            w[j + 1] = q;
            //        }
            //        //if (w[j] < w[j + 1])//降序
            //        //{
            //        //    q = w[j + 1];
            //        //    w[j + 1] = w[j];
            //        //    w[j] = q;
            //        //}
            //    }
            //}
            //foreach (int e in w)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.ReadKey();
            #endregion
            #region 快速排序 






            #endregion
            #region 二分查找


            #endregion
            #region 二分排序

            #endregion
            #region 最大值
            int[] arry = new int[] { 1, 5, 6, 8, 9 };
            Console.WriteLine("以上数组请找到最大数值");

            Max.Pay(arry);
            Console.Read();

            //private static void Pay(int[] arry)
            // {
            //     int Max = 0;
            //     for (int i = 0; i < arry.Length; i++)
            //     {
            //         if (arry[i] > Max)
            //         {
            //             Max = arry[i];

            //         }
            //         else
            //         {
            //             Console.WriteLine("没有最大值");
            //         }
            //     }
            //     Console.WriteLine("最大值是{0}", Max);

            #endregion
            #region 多态虚方法
            //Chinese c1 = new Chinese("黑寡妇");
            //Japanese j1 = new Japanese("黑豹");
            //Korea k1 = new Korea("钢铁侠");
            //American a1 = new American("雷神");
            //Person[] pers = new Person[] { c1, j1, k1, a1, new qwe("宝气") };
            //for (int i = 0; i < pers.Length; i++)
            //{
            //    pers[i].Sayhello();
            //}
            //Console.ReadKey();
            #endregion
            #region 多态深入方法
            //Console.WriteLine("****请选择你想要的东西****"); 
            //string jym = Console.ReadLine();
            //NotBook nb=Program.GetNotBook(jym);
            //nb.SayHello();
            //Console.ReadKey();
            #endregion


        }
        #region 多态虚方法
        //internal class Person
        //{
        //    public string Name { get; set; }
        //    internal Person(string name)
        //    {
        //        this.Name = name;
        //    }
        //    internal virtual void Sayhello()
        //    {

        //        Console.WriteLine("我是蒋先生");
        //    }

        //}
        //internal class Chinese : Person
        //{
        //    internal Chinese(string name) : base(name)
        //    {

        //    }
        //    internal override void Sayhello()
        //    {
        //        Console.WriteLine($"我是中国人,我叫{this.Name}");
        //    }
        //}

        //internal class Japanese : Person
        //{
        //    internal Japanese(string name) : base(name)
        //    {
        //    }
        //    internal override void Sayhello()
        //    {
        //        Console.WriteLine($"我是日本人，我叫{this.Name}");
        //    }
        //}
        //internal class Korea : Person
        //{
        //    internal Korea(string name) : base(name)
        //    { }
        //    internal override void Sayhello()
        //    {
        //        Console.WriteLine($"你是我的滋味，我叫{this.Name}");
        //    }
        //}
        //internal class American : Person
        //{
        //    internal American(string name) : base(name)
        //    {
        //    }
        //    internal override void Sayhello()
        //    {
        //        Console.WriteLine($"你是锤子，你叫{this.Name}");
        //    }

        //}
        //internal class qwe : Person
        //{
        //    internal qwe(string name) : base(name)
        //    { }
        //    internal override void Sayhello()
        //    {

        //        base.Sayhello();//继承父类的方法

        //    }
        //}
        #endregion
        #region 多态深入方法
        public static NotBook GetNotBook(string wer)
        {
            NotBook w = null;
            switch (wer)
            {
                case "Lenovo":
                    w = new Lenovo();
                    break;
                case "Acer": w = new Acer();
                    break;
                case "Dell":w = new Dell();
                    break;
                case "IBM":w = new IBM();
                    break;
            }

            return w;
        }
        #endregion
    }
    #region 多态深入方法
    public abstract class NotBook
    {
        public abstract void SayHello();
    }
    public class Lenovo : NotBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想，整天想念");
        }
    }
    public class Acer : NotBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我就是我，Acer");
        }
    }
    public class Dell : NotBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔，请选择我");
        }
    }
    public class IBM : NotBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是苹果品牌");
        }
    }
    #endregion

   

}

