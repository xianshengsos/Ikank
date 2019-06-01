using System;
using System.Collections.Generic;
using System.Text;

namespace InterFacEp
{
    class interfaceto
    {
        static void Main(string[] args)
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
}
