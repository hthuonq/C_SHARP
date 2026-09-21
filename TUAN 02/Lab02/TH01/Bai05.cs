using System;

namespace TH01
{
    class Bai05
    {
        // Tham số truyền giá trị
        static double TinhLuyThua(double x, double y)
        {
            return Math.Pow(x, y);
        }

        // Tham số ref
        static void TinhCanBacHai(double x, ref double ketQua)
        {
            if (x >= 0)
            {
                ketQua = Math.Sqrt(x);
            }
            else
            {
                ketQua = -1;
            }
        }

        // Tham số out
        static bool KiemTraSoDuong(double x, out double ketQua)
        {
            if (x >= 0)
            {
                ketQua = Math.Sqrt(x);
                return true;
            }

            ketQua = 0;
            return false;
        }

        public static void Chay()
        {
            double x, y;
            int chon;

            Console.Write("Nhap so thuc x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc y: ");
            y = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== MENU BAI 5 =====");
                Console.WriteLine("1. Tinh x mu y");
                Console.WriteLine("2. Tinh can bac hai cua x");
                Console.WriteLine("3. Tinh can bac hai cua y");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");

                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        double ketQuaMu = TinhLuyThua(x, y);
                        Console.WriteLine($"{x} mu {y} = {ketQuaMu}");
                        break;

                    case 2:
                        double ketQuaCanX = 0;
                        TinhCanBacHai(x, ref ketQuaCanX);

                        if (ketQuaCanX == -1)
                        {
                            Console.WriteLine("Khong the tinh can bac hai cua so am!");
                        }
                        else
                        {
                            Console.WriteLine($"Can bac hai cua {x} = {ketQuaCanX}");
                        }
                        break;

                    case 3:
                        double ketQuaCanY;

                        if (KiemTraSoDuong(y, out ketQuaCanY))
                        {
                            Console.WriteLine($"Can bac hai cua {y} = {ketQuaCanY}");
                        }
                        else
                        {
                            Console.WriteLine("Khong the tinh can bac hai cua so am!");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Thoat Bai 5.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

            } while (chon != 0);
        }
    }
}