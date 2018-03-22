using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randome
{
    class Program
    {
        static void Main(string[] args)
        {
            // 產生亂數物件
            Random rand = new Random () ;
            int a =0;

            while (a < 10)
            {
                // 產生6六個亂數，1 <= 亂數範圍 < 43
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);

                // 寫出六個亂數
                Console.WriteLine("號碼：{0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", a, r1, r2, r3, r4, r5, r6);

                a = a + 1;
            }
            // 讓畫面停止
            Console.ReadLine() ;
        }
    }
}
