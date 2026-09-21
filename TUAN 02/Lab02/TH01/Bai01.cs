using System;

namespace TH01
{
    class Bai01
    {
        public static void Chay()
        {
            // Nhập họ tên từ bàn phím
            Console.Write("Nhap ho ten cua ban: ");
            string hoTen = Console.ReadLine();

            // Xuất họ tên vừa nhập
            Console.WriteLine("Chao ban " + hoTen + "!");
        }
    }
}