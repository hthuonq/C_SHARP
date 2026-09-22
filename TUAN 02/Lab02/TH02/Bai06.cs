using System;
using System.Collections;

namespace TH02
{
    class ArrayPoint
    {
        // Field: danh sách các Point
        private ArrayList ds;

        // Constructor mặc định
        public ArrayPoint()
        {
            ds = new ArrayList();
        }

        // Thêm Point
        public void Add(Point p)
        {
            ds.Add(p);
        }

        // Indexer
        public Point this[int i]
        {
            get
            {
                return (Point)ds[i];
            }
            set
            {
                ds[i] = value;
            }
        }

        // Số lượng Point
        public int Count
        {
            get { return ds.Count; }
        }

        // Nhập danh sách Point
        public void Input()
        {
            Console.Write("Nhap so luong Point: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhap Point thu " + (i + 1) + ":");

                Point p = new Point();
                p.Input();

                Add(p);
            }
        }

        // Xuất danh sách Point
        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("----- DANH SACH POINT -----");

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Point[" + i + "] = " + this[i]);
            }
        }
    }

    class Bai06
    {
        public static void Chay()
        {
            ArrayPoint ds = new ArrayPoint();

            ds.Input();
            ds.Output();

            Console.WriteLine();
            Console.WriteLine("----- TRUY CAP BANG INDEXER -----");

            Console.Write("Nhap vi tri Point can xem: ");
            int i = int.Parse(Console.ReadLine());

            if (i >= 0 && i < ds.Count)
            {
                Console.WriteLine("Point[" + i + "] = " + ds[i]);
            }
            else
            {
                Console.WriteLine("Vi tri khong hop le!");
            }
        }
    }
}