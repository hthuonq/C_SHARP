using System;

namespace TH01
{
    class Bai07
    {
        // Phương thức kiểm tra số nguyên tố
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Chay()
        {
            // Nhập n
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            // Kiểm tra và xuất kết quả
            if (LaSoNguyenTo(n))
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
    }
}