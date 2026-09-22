using System;

namespace TH02
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int chon;

            do
            {
                Console.Clear();

                Console.WriteLine("========== THUC HANH 02 ==========");
                Console.WriteLine("========== BAI 1 ==========");
                Console.WriteLine("1. Bai 1.1 - Tinh tuoi sinh vien");
                Console.WriteLine("2. Bai 1.2 - Lop Point");
                Console.WriteLine("3. Bai 1.3 - Lop Person");
                Console.WriteLine("4. Bai 1.4 - Lop Phan so");
                Console.WriteLine("5. Bai 1.5 - Lop Don thuc");
                Console.WriteLine("========== BAI 2 ==========");
                Console.WriteLine("6. Bai 2.1 - Lop ArrayPoint");
                Console.WriteLine("7. Bai 2.2 - Lop PersonList");
                Console.WriteLine("8. Bai 2.3 - Lop day so 1 chieu");
                Console.WriteLine("9. Bai 2.4 - Lop mang 2 chieu");
                Console.WriteLine("10. Bai 2.5 - Lop Da thuc");
                Console.WriteLine("11. Bai 2.6 - Day phan so");
                Console.WriteLine("12. Bai 2.7 - Tinh luong nhan vien");
                Console.WriteLine("========== BAI 3 ==========");
                Console.WriteLine("13. Bai 3.1 - Sap xep doi tuong bang Array.Sort");
                Console.WriteLine("14. Bai 3.2 - Sap xep tong quat bang Interface");
                Console.WriteLine("15. Bai 3.3 - Sap xep tong quat bang Delegate");
                Console.WriteLine("16. Bai 3.4 - ConsoleMenu va giai phuong trinh bac 2");
                Console.WriteLine("17. Bai 3.5 - Ke thua va da hinh tinh luong");
                Console.WriteLine("18. Bai 3.6 - Cham diem thi sinh");
                Console.WriteLine("\n0. Thoat");
                Console.WriteLine("==================================");
                Console.Write("Chon bai: ");

                chon = int.Parse(Console.ReadLine());

                Console.Clear();

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

                    case 18:
                        Bai18.Chay();
                        break;

                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                if (chon != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nhan Enter de quay lai menu...");
                    Console.ReadLine();
                }

            } while (chon != 0);
        }
    }
}