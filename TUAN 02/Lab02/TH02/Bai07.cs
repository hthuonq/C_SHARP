using System;
using System.Collections;

namespace TH02
{
    class PersonList
    {
        private ArrayList ds;

        public PersonList()
        {
            ds = new ArrayList();
        }

        public PersonList(PersonList p)
        {
            ds = new ArrayList();

            for (int i = 0; i < p.ds.Count; i++)
            {
                Person nguoi = new Person((Person)p.ds[i]);
                ds.Add(nguoi);
            }
        }

        public void Add(Person x)
        {
            ds.Add(x);
        }

        public void Input()
        {
            Console.Write("Nhap so luong Person: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhap Person thu " + (i + 1) + ":");

                Person p = new Person();
                p.Input();

                Add(p);
            }
        }

        public void Output()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
                return;
            }

            Console.WriteLine("----- DANH SACH PERSON -----");

            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Person thu " + (i + 1) + ":");
                ((Person)ds[i]).Output();
            }
        }

        public PersonList LivingPeople()
        {
            PersonList ketQua = new PersonList();

            for (int i = 0; i < ds.Count; i++)
            {
                Person p = (Person)ds[i];

                if (p.IsLiving())
                {
                    ketQua.Add(new Person(p));
                }
            }

            return ketQua;
        }
    }

    class Bai07
    {
        public static void Chay()
        {
            PersonList danhSach = new PersonList();

            int chon;

            do
            {
                Console.Clear();

                Console.WriteLine("========== PERSON LIST ==========");
                Console.WriteLine("1. Nhap so luong Person");
                Console.WriteLine("2. Xuat danh sach Person");
                Console.WriteLine("3. Hien thi nguoi con song");
                Console.WriteLine("4. Them Person vao danh sach");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("=================================");
                Console.Write("Chon: ");

                chon = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (chon)
                {
                    case 1:
                        danhSach.Input();
                        break;

                    case 2:
                        danhSach.Output();
                        break;

                    case 3:
                        Console.WriteLine("----- NGUOI CON SONG -----");

                        PersonList nguoiConSong = danhSach.LivingPeople();
                        nguoiConSong.Output();
                        break;

                    case 4:
                        Console.WriteLine("----- THEM PERSON MOI -----");

                        Person p = new Person();
                        p.Input();

                        danhSach.Add(p);

                        Console.WriteLine();
                        Console.WriteLine("Da them Person vao danh sach!");
                        break;

                    case 0:
                        Console.WriteLine("Thoat...");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                if (chon != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nhan Enter de tiep tuc...");
                    Console.ReadLine();
                }

            } while (chon != 0);
        }
    }
}