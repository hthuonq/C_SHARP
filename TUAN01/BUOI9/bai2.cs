using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI9
{
    class bai2
    {
        static int chandautien(int[] a)
        {
            for(int i=0; i< a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        static int chancuoi(int[] a)
        {
            for (int i= a.Length-1; i>=0; i--)
            {
                if (a[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void chay()
        {
            int n;
            int[] a;
            Console.Write("nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("phan tu {0}: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int chan1 = chandautien(a);
            int chan2 = chancuoi(a);

            if (chan1 == -1)
            {
                Console.WriteLine("day so khong chua so chan");
            }
            else
            {
                Console.WriteLine("gia tri chan dau tien o vi tri {0} co gia tri {1}", chan1, a[chan1]);
                Console.WriteLine("gia tri chan cuoi cung o vi tri {0} co gia tr {1}", chan2, a[chan2]);
            }
        }
    }
}
