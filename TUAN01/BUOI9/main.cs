using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI9
{
    class main
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("BUOI 9");
                Console.WriteLine("1. liet ke so chan");
                Console.WriteLine("2. tim gia tri chan dau tien, cuoi cung");
                Console.WriteLine("3. dem dau");
                Console.WriteLine("4. tim kiem");
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
