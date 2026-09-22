using System;

namespace TH02
{
    class Person
    {
        // Field
        private int id;
        private string name;
        private int yob;
        private int yod;

        // Default Constructor
        public Person()
        {
            id = 0;
            name = "";
            yob = 0;
            yod = 0;
        }

        // Copy Constructor
        public Person(Person p)
        {
            id = p.id;
            name = p.name;
            yob = p.yob;
            yod = p.yod;
        }

        // Nhập thông tin
        public void Input()
        {
            Console.Write("Nhap ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            yob = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam mat (0 neu con song): ");
            yod = int.Parse(Console.ReadLine());
        }

        // Xuất thông tin
        public void Output()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Ho ten: " + name);
            Console.WriteLine("Nam sinh: " + yob);
            Console.WriteLine("Nam mat: " + yod);
        }

        // Kiểm tra còn sống
        public bool IsLiving()
        {
            return yod == 0;
        }
    }

    class Bai03
    {
        public static void Chay()
        {
            Person p1 = new Person();

            Console.WriteLine("----- NHAP THONG TIN PERSON -----");
            p1.Input();

            Console.WriteLine();
            Console.WriteLine("----- THONG TIN PERSON -----");
            p1.Output();

            if (p1.IsLiving())
                Console.WriteLine("Trang thai: Con song");
            else
                Console.WriteLine("Trang thai: Da mat");

            // Test Copy Constructor
            Person p2 = new Person(p1);

            Console.WriteLine();
            Console.WriteLine("----- PERSON SAO CHEP -----");
            p2.Output();
        }
    }
}