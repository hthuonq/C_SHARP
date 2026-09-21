using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    class Bai03
    {
        public static void Chay()
        {
            // Nhập số nguyên x
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());

            // Nhập số nguyên y
            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine());

            // Tính x mũ y
            double ketQua = Math.Pow(x, y);

            // Xuất kết quả
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}
