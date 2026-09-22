using System;

namespace TH02
{
    class DayPhanSo
    {
        private PhanSo[] a;

        // Constructor mặc định
        public DayPhanSo()
        {
            a = new PhanSo[0];
        }

        // Constructor có tham số
        public DayPhanSo(int n)
        {
            a = new PhanSo[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new PhanSo();
            }
        }

        // Indexer
        public PhanSo this[int i]
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

        // Nhập dãy phân số
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Phan so thu " + (i + 1));

                Console.Write("Nhap tu so: ");
                int tu = int.Parse(Console.ReadLine());

                Console.Write("Nhap mau so: ");
                int mau = int.Parse(Console.ReadLine());

                a[i] = new PhanSo(tu, mau);
            }
        }

        // Xuất dãy phân số
        public void Output()
        {
            Console.Write("Day phan so: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);

                if (i < a.Length - 1)
                    Console.Write(" + ");
            }

            Console.WriteLine();
        }

        // Tính tổng
        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo();

            for (int i = 0; i < a.Length; i++)
            {
                tong = tong + a[i];
            }

            return tong;
        }
    }

    class Bai11
    {
        public static void Chay()
        {
            Console.Write("Nhap so luong phan so: ");
            int n = int.Parse(Console.ReadLine());

            DayPhanSo day = new DayPhanSo(n);

            Console.WriteLine();
            day.Input();

            Console.WriteLine();
            day.Output();

            PhanSo tong = day.TinhTong();

            Console.WriteLine("Tong = " + tong);

            Console.WriteLine();
            Console.Write("Nhap vi tri phan so muon xem: ");
            int i = int.Parse(Console.ReadLine());

            if (i >= 0 && i < n)
            {
                Console.WriteLine("Phan so thu " + i + " = " + day[i]);
            }
            else
            {
                Console.WriteLine("Vi tri khong hop le!");
            }
        }
    }
}