using System;

namespace TH01
{
    class Bai17
    {
        static void TaoMang(int[,] a)
        {
            Random random = new Random();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(10, 101);
                }
            }
        }

        static void XuatMang(int[,] a)
        {
            Console.WriteLine("Ma tran:");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void TachChanLe(int[,] a, out int[] chan, out int[] le)
        {
            int demChan = 0;
            int demLe = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 == 0)
                        demChan++;
                    else
                        demLe++;
                }
            }

            chan = new int[demChan];
            le = new int[demLe];

            int viTriChan = 0;
            int viTriLe = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        chan[viTriChan] = a[i, j];
                        viTriChan++;
                    }
                    else
                    {
                        le[viTriLe] = a[i, j];
                        viTriLe++;
                    }
                }
            }
        }

        public static void Chay()
        {
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];

            TaoMang(a);
            XuatMang(a);

            int[] chan;
            int[] le;

            TachChanLe(a, out chan, out le);

            Console.Write("Mang so chan: ");
            for (int i = 0; i < chan.Length; i++)
            {
                Console.Write(chan[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Mang so le: ");
            for (int i = 0; i < le.Length; i++)
            {
                Console.Write(le[i] + " ");
            }

            Console.WriteLine();
        }
    }
}