using System;

namespace TH01
{
    class Bai11
    {
        static string DaoChuoi(string chuoi)
        {
            string ketQua = "";

            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                ketQua += chuoi[i];
            }

            return ketQua;
        }

        public static void Chay()
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();

            string ketQua = DaoChuoi(chuoi);

            Console.WriteLine($"Chuoi dao nguoc: {ketQua}");
        }
    }
}