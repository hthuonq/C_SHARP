using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class main
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("BUOI 2");
                Console.WriteLine("1. tinh tong doan");
                Console.WriteLine("2. luy thua nhanh 1");
                Console.WriteLine("3. tinh bieu thuc nhanh 1");
                Console.WriteLine("4. tim qui");
                Console.WriteLine("0. thoat");

                Console.WriteLine("chon bai: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        bai1.chay();
                        break;
                    case 2:
                        bai2.chay();
                        break;
                    case 3:
                        bai3.chay();
                        break;
                    case 4:
                        bai4.chay();
                        break;
                    case 0:
                        Console.WriteLine("ket thuc");
                        break;
                    default:
                        Console.WriteLine("lua chon khong hop le");
                        break;
                }
                if (choice != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("nhan Enter de quay lai menu");
                    Console.ReadLine();

                }

            } while (choice != 0);
        }
    }
}
