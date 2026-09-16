using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class bai2
    {
        public static void chay()
        {
            double a;
            double a2; //a2= a*a
            double a4; //a4= a2*a2
            double a5; //a5= a4*a
            double a8; // a8= a4*a4
            double a16; // a16= a8*a8
            double a17; // a17 = a16*a

            Console.WriteLine("nhap so thuc a: ");
            a= double.Parse(Console.ReadLine());

            a2 = a * a;
            a4 = a2 * a2;
            a5 = a4 * a2;
            a8 = a4 * a4;
            a16 = a8 * a8;
            a17 = a16 * a;

            Console.WriteLine("ket qua: {0}^2 = {1:#.00}, {0}^5 = {2:#.00}, {0}^17 = {3:#.00}", a, a2, a5, a17); // :#.00 là định dạng số, hiển thị 2 chữ số thập phân


        }
    }
}
