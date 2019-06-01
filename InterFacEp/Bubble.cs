using System;
using System.Collections.Generic;
using System.Text;

namespace InterFacEp
{
    class Bubble:Sort
    {
        public void shit(int[] sz)
        {
            int w = 0;
            for (int i = 0; i < sz.Length - 1; i++) //计算一共要循环几次   w.Length从0开始计算一共次数 
            {

                for (int j = 0; j < sz.Length - i - 1; j++) //数值一共比较几次 w.Length-1+i还剩的数
                {


                    if (sz[j] < sz[j + 1])//变成升序改变>
                    {

                        w = sz[j];
                        sz[j] = sz[j + 1];
                        sz[j + 1] = w;

                    }

                }
            }
            //for (int i = 0; i < sz.Length; i++)
            //    {
            //    Console.WriteLine(sz[i]);
            //     }
            foreach (var jym in sz)
            {
                Console.WriteLine(jym);
            }
        }
    }
}
