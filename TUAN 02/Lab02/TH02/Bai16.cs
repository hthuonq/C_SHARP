using System;

namespace TH02
{
    // Lớp menu cơ bản
    class ConsoleMenu
    {
        protected string[] menu;

        public ConsoleMenu(string[] menu)
        {
            this.menu = menu;
        }

        public virtual void HienThiMenu()
        {
            Console.WriteLine("========== MENU ==========");

            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + menu[i]);
            }

            Console.WriteLine("0. Thoat");
            Console.WriteLine("==========================");
        }

        public virtual void ThucHien(int chon)
        {
            Console.WriteLine("Ban thuc hien chuc nang " + chon);
        }

        public void Chay()
        {
            int chon;

            do
            {
                Console.Clear();

                HienThiMenu();

                Console.Write("Chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());

                if (chon != 0)
                {
                    Console.Clear();
                    ThucHien(chon);

                    Console.WriteLine();
                    Console.WriteLine("Nhan Enter de tiep tuc...");
                    Console.ReadLine();
                }

            } while (chon != 0);
        }
    }


    // Lớp giải phương trình bậc 2 kế thừa ConsoleMenu
    class GiaiPhuongTrinhBac2 : ConsoleMenu
    {
        public GiaiPhuongTrinhBac2(string[] menu)
            : base(menu)
        {
        }

        public override void ThucHien(int chon)
        {
            Console.WriteLine("Ban thuc hien chuc nang " + chon);

            if (chon == 1)
            {
                GiaiPhuongTrinh();
            }
            else
            {
                Console.WriteLine("Chuc nang khong hop le!");
            }
        }

        private void GiaiPhuongTrinh()
        {
            Console.WriteLine();
            Console.WriteLine("===== GIAI PHUONG TRINH BAC 2 =====");
            Console.WriteLine("ax^2 + bx + c = 0");

            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem x = " + x);
                }

                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }


    class Bai16
    {
        public static void Chay()
        {
            string[] menu =
            {
                "Giai phuong trinh bac 2"
            };

            GiaiPhuongTrinhBac2 chuongTrinh =
                new GiaiPhuongTrinhBac2(menu);

            chuongTrinh.Chay();
        }
    }
}