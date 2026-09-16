using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class bai3
    {
        public static void chay()
        {
            double x, f;
            Console.Write("Nhap x: ");
            x= double.Parse(Console.ReadLine());
            f = 1 + x * (2 + x * (3 - 4 * x)); // horner biểu thức: f(x)= 1+ 2x +3x^2 -4x^3

            Console.WriteLine("f{0} = {1:#.00}", x, f);
        }
    }
}