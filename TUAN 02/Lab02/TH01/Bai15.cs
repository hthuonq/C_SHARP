using System;

namespace TH01
{
    class Bai15
    {
        static void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatMang(int[] a)
        {
            Console.Write("Mang: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }

        static int TimMin(int[] a)
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }

        static int TimMax(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int[] LaySoNguyenTo(int[] a)
        {
            int dem = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (LaSoNguyenTo(a[i]))
                {
                    dem++;
                }
            }

            int[] ketQua = new int[dem];
            int viTri = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (LaSoNguyenTo(a[i]))
                {
                    ketQua[viTri] = a[i];
                    viTri++;
                }
            }

            return ketQua;
        }

        public static void Chay()
        {
            Console.Write("Nhap so phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            NhapMang(a);
            XuatMang(a);

            Console.WriteLine("Gia tri nho nhat: " + TimMin(a));
            Console.WriteLine("Gia tri lon nhat: " + TimMax(a));

            int[] soNguyenTo = LaySoNguyenTo(a);

            Console.Write("Cac so nguyen to: ");

            for (int i = 0; i < soNguyenTo.Length; i++)
            {
                Console.Write(soNguyenTo[i] + " ");
            }

            Console.WriteLine();
        }
    }
}