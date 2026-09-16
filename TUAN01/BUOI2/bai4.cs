using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class bai4
    {
        public static void chay()
        {
            int thang, qui;
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());

            qui = (thang - 1) / 3 + 1;
            Console.WriteLine("thang {0} thuoc qui {1}", thang, qui);
        }
    }
}