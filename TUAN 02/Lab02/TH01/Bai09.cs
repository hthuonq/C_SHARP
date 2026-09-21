using System;

namespace TH01
{
    class Bai09
    {
        static void TimMaxMin(double a, double b, double c, out double max, out double min)
        {
            max = a;
            min = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            if (b < min)
                min = b;

            if (c < min)
                min = c;
        }

        public static void Chay()
        {
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine());

            double max, min;

            TimMaxMin(a, b, c, out max, out min);

            Console.WriteLine($"Gia tri lon nhat: {max}");
            Console.WriteLine($"Gia tri nho nhat: {min}");
        }
    }
}