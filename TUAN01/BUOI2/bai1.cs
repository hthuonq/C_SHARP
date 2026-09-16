using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class bai1
    {
        public static void chay()
        {
            int a, b;
            int tong;

            Console.Write("Nhap a, b: ");
            string[] num  = Console.ReadLine().Split(); // nhập dữ liệu rồi tách chuỗi

            // chuyển phần tử thành số nguyên
            a = int.Parse(num[0]); // num[0] : vị trí đầu tiên của mảng
            b = int.Parse(num[1]);

            tong = b * (b + 1) / 2 - (a - 1) * a / 2;
            Console.WriteLine("tong cua cac so trong doan [{0}, {1}] là {2} ", a, b, tong); // {0},{1},{2} là vị trí để đưa giá trị biến vào chuỗi.
        }
    }
}
