using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI7
{
    class bai3
    {
        static double tinhpi(double epsilon)
        {
            double tong=0, sohang;
            int n = 0, dau = 1;

            do
            {
                sohang = 1.0 / (2 * n + 1);
                tong = tong + (dau * sohang);
                dau = -dau;
                n++;
            }
            while (4 * sohang >= epsilon);
            return 4 * tong;
        }
        public static void chay()
        {
            double epsilon, pi, saiso;
            Console.Write("nhap sai so epilon: ");
            epsilon = double.Parse(Console.ReadLine());

            pi = tinhpi(epsilon);
            saiso = Math.Abs(Math.PI - pi);

            Console.WriteLine("so pi tinh den do chinh xac {0} la {1:#.00000}", epsilon, pi);
            Console.WriteLine("do sai so thuc te la {0}", saiso);
        }
    }
}