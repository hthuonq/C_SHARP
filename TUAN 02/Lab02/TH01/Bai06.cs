using System;

namespace TH01
{
    class Bai06
    {
        // Phương thức trả về giá trị lớn nhất
        static int TimMax(int a, int b, int c)
        {
            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            return max;
        }

        public static void Chay()
        {
            // Nhập 3 số nguyên
            Console.Write("Nhap so nguyen a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen c: ");
            int c = int.Parse(Console.ReadLine());

            // Tìm giá trị lớn nhất
            int max = TimMax(a, b, c);

            // Xuất kết quả
            Console.WriteLine($"Gia tri lon nhat cua {a}, {b}, {c} la: {max}");
        }
    }
}