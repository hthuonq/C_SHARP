using System;

namespace TH02
{
    class DaThuc
    {
        private DonThuc[] a;

        // Constructor mac dinh
        public DaThuc()
        {
            a = new DonThuc[0];
        }

        // Constructor co tham so
        // n la bac cua da thuc
        // => co n + 1 don thuc
        public DaThuc(int n)
        {
            a = new DonThuc[n + 1];

            for (int i = 0; i <= n; i++)
            {
                a[i] = new DonThuc();
            }
        }

        // Copy Constructor
        public DaThuc(DaThuc p)
        {
            a = new DonThuc[p.a.Length];

            for (int i = 0; i < p.a.Length; i++)
            {
                a[i] = new DonThuc(p.a[i]);
            }
        }

        // Indexer
        public DonThuc this[int i]
        {
            get
            {
                return a[i];
            }
            set
            {
                a[i] = value;
            }
        }

        // Nhap da thuc
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap he so a" + i + ": ");
                double heSo = double.Parse(Console.ReadLine());

                a[i] = new DonThuc(heSo, i);
            }
        }

        // Xuat da thuc
        public void Output()
        {
            Console.Write("P(x) = ");

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(a[i]);
                }
                else
                {
                    Console.Write(a[i] + " + ");
                }
            }

            Console.WriteLine();
        }

        // Tinh P(x)
        public double TinhGiaTri(double x)
        {
            double tong = 0;

            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i].TinhGiaTri(x);
            }

            return tong;
        }
    }

    class Bai10
    {
        public static void Chay()
        {
            Console.Write("Nhap bac cua da thuc n: ");
            int n = int.Parse(Console.ReadLine());

            DaThuc p = new DaThuc(n);

            Console.WriteLine();
            Console.WriteLine("===== NHAP DA THUC =====");
            p.Input();

            Console.WriteLine();
            Console.WriteLine("===== DA THUC =====");
            p.Output();

            Console.WriteLine();
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("P(" + x + ") = " + p.TinhGiaTri(x));

            Console.WriteLine();
            Console.Write("Nhap vi tri don thuc muon xem: ");
            int i = int.Parse(Console.ReadLine());

            if (i >= 0 && i <= n)
            {
                Console.WriteLine("Don thuc thu " + i + ": " + p[i]);
            }
            else
            {
                Console.WriteLine("Vi tri khong hop le!");
            }
        }
    }
}