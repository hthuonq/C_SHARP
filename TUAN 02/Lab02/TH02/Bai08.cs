using System;

namespace TH02
{
    class DaySo
    {
        private int[] a;

        // Constructor mặc định
        public DaySo()
        {
            a = new int[0];
        }

        // Constructor có tham số
        public DaySo(int n)
        {
            a = new int[n];
        }

        // Copy Constructor
        public DaySo(DaySo d)
        {
            a = new int[d.a.Length];

            for (int i = 0; i < d.a.Length; i++)
            {
                a[i] = d.a[i];
            }
        }

        // Indexer
        public int this[int i]
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

        // Nhập dãy
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Xuất dãy
        public void Output()
        {
            Console.Write("Day so: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }

        // Tìm các số chẵn
        public void TimSoChan()
        {
            Console.Write("Cac so chan: ");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }

    class Bai08
    {
        public static void Chay()
        {
            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            DaySo day = new DaySo(n);

            Console.WriteLine();
            day.Input();

            Console.WriteLine();
            day.Output();

            day.TimSoChan();

            Console.WriteLine();
            Console.Write("Nhap vi tri muon xem: ");
            int i = int.Parse(Console.ReadLine());

            if (i >= 0 && i < n)
            {
                Console.WriteLine("a[" + i + "] = " + day[i]);
            }
            else
            {
                Console.WriteLine("Vi tri khong hop le!");
            }
        }
    }
}