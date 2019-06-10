using System;
using System.Collections.Generic;
using System.Text;

namespace InterFacEp
{
    class interfaceto
    {
        static void call()
        {
            int[] q = new int[10];
            Random r = new Random();
            for (int i = 0; i < q.Length; i++)
            {
                q[i] = r.Next(1, 99);
            }
            Sort mao = new Bubble();

            mao.shit(q);
            Console.WriteLine("****蒋先生版权****");
            Console.ReadKey();


        }
    }
    interface Sort
    {
        void shit(int[] sz);
    }
    class Bubble : Sort
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
