using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI9
{
    class bai1
    {
        public static void chay()
        {
            int n;
            int[] a;
            Console.Write("Nhap so luong phan tu trong mang: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.Write("Phan tu {0} la: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("cac phan tu so chan trong mang: ");
            for(int i=n-1; i>=0; i--)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write("{0} ", a[i]);
                }
            }
            Console.WriteLine();
        }
    }
}