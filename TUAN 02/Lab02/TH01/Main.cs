using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    class MainProgram
    {
        static void Main()
        {
            int chon;

            do
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Bai 1 - Ma nguon chuong trinh");
                Console.WriteLine("2. Bai 2 - Loi chao");
                Console.WriteLine("3. Bai 3 - Tinh x mu y");
                Console.WriteLine("4. Bai 4 - Tinh x mu y va kiem tra loi");
                Console.WriteLine("5. Bai 5 - Tinh toan voi so thuc");
                Console.WriteLine("6. Bai 6 - Tim gia tri lo nhat cua 3 so nguyen");
                Console.WriteLine("7. Bai 7 - Kiem tra so nguyen to");
                Console.WriteLine("8. Bai 8 - Hoan vi");
                Console.WriteLine("9. Bai 9 - Tim gia tri nho nhat va lon nhat cua 3 so thuc");
                Console.WriteLine("10. Bai 10 - Kiem tra chuoi doi xung");
                Console.WriteLine("11. Bai 11 - Dao chuoi");
                Console.WriteLine("12. Bai 12 - Chuyen sang ki tu thuong, hoa, dem so tu trong chuoi");
                Console.WriteLine("13. Bai 13 - Nhap , xuat 1 sinh vien");
                Console.WriteLine("14. Bai 14 - Tinh luong nhan vien");
                Console.WriteLine("15. Bai 15 - Xu ly mang so nguyen");
                Console.WriteLine("16. Bai 16 - Sap xep mang ho ten");
                Console.WriteLine("17. Bai 17 - Tao ma tran, tra ve chan le");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");

                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Bai01.Chay();
                        break;
                    case 2:
                        Bai02.Chay();
                        break;
                    case 3:
                        Bai03.Chay();
                        break;
                    case 4:
                        Bai04.Chay();
                        break;
                    case 5:
                        Bai05.Chay();
                        break;
                    case 6:
                        Bai06.Chay();
                        break;
                    case 7:
                        Bai07.Chay();
                        break;
                    case 8:
                        Bai08.Chay();
                        break;
                    case 9:
                        Bai09.Chay();
                        break;
                    case 10:
                        Bai10.Chay();
                        break;
                    case 11:
                        Bai11.Chay();
                        break;
                    case 12:
                        Bai12.Chay();
                        break;
                    case 13:
                        Bai13.Chay();
                        break;
                    case 14:
                        Bai14.Chay();
                        break;
                    case 15:
                        Bai15.Chay();
                        break;
                    case 16:
                        Bai16.Chay();
                        break;
                    case 17:
                        Bai17.Chay();
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                Console.WriteLine();

            } while (chon != 0);
        }
    }
}
