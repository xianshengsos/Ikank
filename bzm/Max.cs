using System;
using System.Collections.Generic;
using System.Text;

namespace bzm
{
    class Max
    {
        #region 最大值
        public static void Pay(int[] arry)
        {
            int Max = 0;
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] > Max)
                {
                    Max = arry[i];

                }
                else
                {
                    Console.WriteLine("没有最大值");
                }
            }
            Console.WriteLine("最大值是{0}", Max);

        }
        #endregion
    }
}
