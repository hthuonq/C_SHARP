using System;

namespace TH01
{
    class Bai10
    {
        static bool LaChuoiDoiXung(string chuoi)
        {
            int dau = 0;
            int cuoi = chuoi.Length - 1;

            while (dau < cuoi)
            {
                if (chuoi[dau] != chuoi[cuoi])
                {
                    return false;
                }

                dau++;
                cuoi--;
            }

            return true;
        }

        public static void Chay()
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();

            if (LaChuoiDoiXung(chuoi))
            {
                Console.WriteLine("Chuoi doi xung.");
            }
            else
            {
                Console.WriteLine("Chuoi khong doi xung.");
            }
        }
    }
}