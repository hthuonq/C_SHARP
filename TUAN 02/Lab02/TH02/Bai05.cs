using System;

namespace TH02
{
    class DonThuc
    {
        private double a;
        private int n;

        // Constructor mặc định
        public DonThuc()
        {
            a = 0;
            n = 0;
        }

        // Constructor có tham số
        public DonThuc(double a, int n)
        {
            if (n < 0)
                throw new Exception("So mu phai >= 0!");

            this.a = a;
            this.n = n;
        }

        // Copy Constructor
        public DonThuc(DonThuc p)
        {
            a = p.a;
            n = p.n;
        }

        // Tính giá trị P(x)
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        // Tính đạo hàm
        public DonThuc DaoHam()
        {
            if (n == 0)
                return new DonThuc(0, 0);

            return new DonThuc(a * n, n - 1);
        }

        // ToString
        public override string ToString()
        {
            if (a == 0)
                return "0";

            if (n == 0)
                return a.ToString();

            if (n == 1)
                return a + "x";

            return a + "x^" + n;
        }
    }

    class Bai05
    {
        public static void Chay()
        {
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so mu n: ");
            int n = int.Parse(Console.ReadLine());

            DonThuc p = new DonThuc(a, n);

            Console.WriteLine();
            Console.WriteLine("Don thuc P(x) = " + p);

            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());

            double ketQua = p.TinhGiaTri(x);

            Console.WriteLine("P(" + x + ") = " + ketQua);

            DonThuc daoHam = p.DaoHam();

            Console.WriteLine("Dao ham P'(x) = " + daoHam);
        }
    }
}