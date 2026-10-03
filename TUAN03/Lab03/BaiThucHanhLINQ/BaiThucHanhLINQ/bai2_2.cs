using System;
using System.Collections.Generic;
using System.Text;

namespace BaiThucHanhLINQ
{
     class bai2_2
    {
        public static void xuly()
        {
            string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
                    "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };
            var cauA = from chuoi in mangChuoi
                       where chuoi.Length == 4
                       select chuoi;

            Console.WriteLine("Cau a:");
            foreach (var chuoi in cauA)
            {
                Console.Write(chuoi + " ");
            }
            Console.WriteLine();
            var cauB = from chuoi in mangChuoi
                       select chuoi.ToUpper() == chuoi ? chuoi.ToLower() : chuoi.ToUpper();
            Console.WriteLine("Cau b:");
            foreach (var chuoi in cauB)
            {
                Console.Write(chuoi + " ");
            }
            var cauC = from chuoi in mangChuoi
                       where chuoi.Contains("u")
                       select chuoi;
            Console.WriteLine("Cau c:");
            foreach (var chuoi in cauC)
            {
                Console.Write(chuoi + " ");
            }
            var cauD = from chuoi in mangChuoi
                       where char.IsUpper(chuoi[0])
                       select chuoi;
            Console.WriteLine("Cau d:");
            foreach (var chuoi in cauD)
            {
                Console.Write(chuoi + " ");
            }
        }
    }
}
