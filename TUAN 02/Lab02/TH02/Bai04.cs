using System;

namespace TH02
{
    class PhanSo
    {
        private int tu;
        private int mau;

        // Constructor mặc định
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }

        // Constructor có tham số
        public PhanSo(int tu, int mau)
        {
            if (mau == 0)
                throw new Exception("Mau so khong duoc bang 0!");

            this.tu = tu;
            this.mau = mau;
        }

        // Copy Constructor
        public PhanSo(PhanSo p)
        {
            tu = p.tu;
            mau = p.mau;
        }

        // Rút gọn phân số
        private void RutGon()
        {
            int a = Math.Abs(tu);
            int b = Math.Abs(mau);

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            if (a != 0)
            {
                tu /= a;
                mau /= a;
            }

            if (mau < 0)
            {
                tu = -tu;
                mau = -mau;
            }
        }

        // ToString
        public override string ToString()
        {
            RutGon();

            if (mau == 1)
                return tu.ToString();

            return tu + "/" + mau;
        }

        // Toán tử một ngôi +
        public static PhanSo operator +(PhanSo p)
        {
            return new PhanSo(p);
        }

        // Toán tử một ngôi -
        public static PhanSo operator -(PhanSo p)
        {
            return new PhanSo(-p.tu, p.mau);
        }

        // Toán tử +
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(
                a.tu * b.mau + b.tu * a.mau,
                a.mau * b.mau
            );
        }

        // Toán tử -
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(
                a.tu * b.mau - b.tu * a.mau,
                a.mau * b.mau
            );
        }

        // Toán tử *
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(
                a.tu * b.tu,
                a.mau * b.mau
            );
        }

        // Toán tử /
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.tu == 0)
                throw new Exception("Khong the chia cho phan so 0!");

            return new PhanSo(
                a.tu * b.mau,
                a.mau * b.tu
            );
        }

        // So sánh >
        public static bool operator >(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau > b.tu * a.mau;
        }

        // So sánh <
        public static bool operator <(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau < b.tu * a.mau;
        }

        // So sánh >=
        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau >= b.tu * a.mau;
        }

        // So sánh <=
        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau <= b.tu * a.mau;
        }

        // So sánh ==
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau == b.tu * a.mau;
        }

        // So sánh !=
        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return a.tu * b.mau != b.tu * a.mau;
        }

        public override bool Equals(object obj)
        {
            if (obj is PhanSo p)
                return this == p;

            return false;
        }

        public override int GetHashCode()
        {
            return (tu, mau).GetHashCode();
        }
    }

    class Bai04
    {
        public static void Chay()
        {
            PhanSo a = new PhanSo(1, 2);
            PhanSo b = new PhanSo(2, 3);

            Console.WriteLine("Phan so a = " + a);
            Console.WriteLine("Phan so b = " + b);

            Console.WriteLine();
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));

            Console.WriteLine();
            Console.WriteLine("+a = " + (+a));
            Console.WriteLine("-a = " + (-a));

            Console.WriteLine();
            Console.WriteLine("a > b: " + (a > b));
            Console.WriteLine("a < b: " + (a < b));
            Console.WriteLine("a >= b: " + (a >= b));
            Console.WriteLine("a <= b: " + (a <= b));
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != b: " + (a != b));

            PhanSo c = new PhanSo(a);

            Console.WriteLine();
            Console.WriteLine("Phan so c sao chep tu a = " + c);
        }
    }
}