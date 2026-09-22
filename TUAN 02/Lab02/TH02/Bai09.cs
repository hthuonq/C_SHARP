using System;

namespace TH02
{
    class MaTran
    {
        private int[,] a;

        // Constructor mặc định
        public MaTran()
        {
            a = new int[0, 0];
        }

        // Constructor có tham số
        public MaTran(int n, int m)
        {
            a = new int[n, m];
        }

        // Copy Constructor
        public MaTran(MaTran mt)
        {
            int n = mt.a.GetLength(0);
            int m = mt.a.GetLength(1);

            a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = mt.a[i, j];
                }
            }
        }

        // Indexer
        public int this[int i, int j]
        {
            get
            {
                return a[i, j];
            }
            set
            {
                a[i, j] = value;
            }
        }

        // Nhập ma trận
        public void Input()
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Nhap a[" + i + "," + j + "]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Xuất ma trận
        public void Output()
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            Console.WriteLine("Ma tran:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        // Kiểm tra số nguyên tố
        private bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }

        // Tìm các số nguyên tố
        public void TimSoNguyenTo()
        {
            Console.Write("Cac so nguyen to: ");

            int n = a.GetLength(0);
            int m = a.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (LaSoNguyenTo(a[i, j]))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }

    class Bai09
    {
        public static void Chay()
        {
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());

            MaTran mt = new MaTran(n, m);

            Console.WriteLine();
            mt.Input();

            Console.WriteLine();
            mt.Output();

            mt.TimSoNguyenTo();

            Console.WriteLine();
            Console.Write("Nhap dong i: ");
            int i = int.Parse(Console.ReadLine());

            Console.Write("Nhap cot j: ");
            int j = int.Parse(Console.ReadLine());

            if (i >= 0 && i < n && j >= 0 && j < m)
            {
                Console.WriteLine("a[" + i + "," + j + "] = " + mt[i, j]);
            }
            else
            {
                Console.WriteLine("Vi tri khong hop le!");
            }
        }
    }
}