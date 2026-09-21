using System;

namespace TH01
{
    class Bai12
    {
        public static void Chay()
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();

            Console.WriteLine("Chuoi viet thuong: " + chuoi.ToLower());
            Console.WriteLine("Chuoi viet hoa: " + chuoi.ToUpper());

            string[] tu = chuoi.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries
            );

            Console.WriteLine("So tu trong chuoi: " + tu.Length);
        }
    }
}