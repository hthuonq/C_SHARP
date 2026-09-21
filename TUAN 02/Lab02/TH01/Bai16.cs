using System;

namespace TH01
{
    class Bai16
    {
        public static void Chay()
        {
            Console.Write("Nhap so luong ho ten: ");
            int n = int.Parse(Console.ReadLine());

            string[] danhSach = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ho ten thu {i + 1}: ");
                danhSach[i] = Console.ReadLine();
            }

            Array.Sort(danhSach);

            Console.WriteLine("Danh sach sau khi sap xep:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(danhSach[i]);
            }
        }
    }
}