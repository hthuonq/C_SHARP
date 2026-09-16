using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI7
{
    class main
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("BUOI 7");
                Console.WriteLine("1. in hinmh tam giac va hinh vuong");
                Console.WriteLine("2. kiem tra so hoan hao");
                Console.WriteLine("3. tinh so pi");
                Console.WriteLine("4. ngay truoc");
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
