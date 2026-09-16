using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI7
{
    class bai1
    {
        static void VeTamGiac(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                // Khoảng trắng bên trái
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                // In *
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        // Hàm vẽ hình vuông
        static void VeHinhVuong(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        public static void chay()
        {
            Console.Write("Moi ban nhap chieu cao h: ");
            int h = int.Parse(Console.ReadLine());

            for (int n = h; n <= h + 4; n += 2)
            {
                Console.WriteLine("\nTam giac n = " + n);
                VeTamGiac(n);

                Console.WriteLine("Hinh vuong n = " + n);
                VeHinhVuong(n);
            }
        }

    }
}