using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI7
{
    class bai2
    {
        static bool sohoanhao(int n)
        {
            int tong = 0;
            for(int i=1; i < n; i++)
            {
                if(n % i == 0)
                {
                    tong = tong + i;
                }
           
            }
            return tong == n;

        }
        public static void chay()
        {
            int n;
            Console.Write("nhap n: ");
            n = int.Parse(Console.ReadLine());

            if (sohoanhao(n))
            {
                Console.Write("{0} la so hoan hao", n);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so hoan hao", n);
            }
        }
    }
}