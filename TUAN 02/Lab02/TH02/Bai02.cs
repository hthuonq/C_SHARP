using System;

namespace TH02
{
    class Point
    {
        // Field
        private double x;
        private double y;

        // Property
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Constructor mặc định
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Nhập tọa độ
        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        // Xuất tọa độ
        public void Output()
        {
            Console.WriteLine($"({x}, {y})");
        }

        // ToString
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // Toán tử +
        public static Point operator +(Point a, Point b)
        {
            Point kq = new Point();
            kq.x = a.x + b.x;
            kq.y = a.y + b.y;
            return kq;
        }

        // Toán tử -
        public static Point operator -(Point a, Point b)
        {
            Point kq = new Point();
            kq.x = a.x - b.x;
            kq.y = a.y - b.y;
            return kq;
        }

        // Lấy âm
        public static Point operator -(Point a)
        {
            Point kq = new Point();
            kq.x = -a.x;
            kq.y = -a.y;
            return kq;
        }

        // Khoảng cách: phương thức thành viên
        public double KhoangCach(Point b)
        {
            double dx = x - b.x;
            double dy = y - b.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Khoảng cách: phương thức tĩnh
        public static double KhoangCach(Point a, Point b)
        {
            double dx = a.x - b.x;
            double dy = a.y - b.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Trung điểm: phương thức thành viên
        public Point TrungDiem(Point b)
        {
            Point kq = new Point();

            kq.x = (x + b.x) / 2;
            kq.y = (y + b.y) / 2;

            return kq;
        }

        // Trung điểm: phương thức tĩnh
        public static Point TrungDiem(Point a, Point b)
        {
            Point kq = new Point();

            kq.x = (a.x + b.x) / 2;
            kq.y = (a.y + b.y) / 2;

            return kq;
        }
    }

    class Bai02
    {
        public static void Chay()
        {
            Point A = new Point();
            Point B = new Point();

            Console.WriteLine("Nhap diem A:");
            A.Input();

            Console.WriteLine("Nhap diem B:");
            B.Input();

            Console.WriteLine();
            Console.WriteLine("----- THONG TIN 2 DIEM -----");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

            // Khoang cach
            Console.WriteLine();
            Console.WriteLine("Khoang cach AB - phuong thuc thanh vien: "
                + A.KhoangCach(B));

            Console.WriteLine("Khoang cach AB - phuong thuc tinh: "
                + Point.KhoangCach(A, B));

            // Trung diem
            Point I1 = A.TrungDiem(B);
            Point I2 = Point.TrungDiem(A, B);

            Console.WriteLine();
            Console.WriteLine("Trung diem - phuong thuc thanh vien: " + I1);
            Console.WriteLine("Trung diem - phuong thuc tinh: " + I2);

            // Toan tu
            Console.WriteLine();
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("-A = " + (-A));
        }
    }
}