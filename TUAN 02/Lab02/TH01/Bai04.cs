using System;

namespace TH01
{
    class Bai04
    {
        public static void Chay()
        {
            // Nhập số nguyên x
            Console.Write("Nhap so nguyen x: ");
            string inputX = Console.ReadLine();

            // Kiểm tra x có phải số nguyên không
            if (!int.TryParse(inputX, out int x))
            {
                Console.WriteLine("Loi: x phai la so nguyen!");
                return;
            }

            // Nhập số nguyên y
            Console.Write("Nhap so nguyen y: ");
            string inputY = Console.ReadLine();

            // Kiểm tra y có phải số nguyên không
            if (!int.TryParse(inputY, out int y))
            {
                Console.WriteLine("Loi: y phai la so nguyen!");
                return;
            }

            // Tính x mũ y
            double ketQua = Math.Pow(x, y);

            // Xuất kết quả
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}