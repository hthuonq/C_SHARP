using System;
using System.Linq;

class bai2_1
{
    public static void xuly()
    {
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
        var cauA = from so in mangSo
                   where so % 4 == 0 && so % 3 == 0
                   select so;

        Console.WriteLine("Cau a:");
        foreach (var so in cauA)
        {
            Console.Write(so + " ");
        }

        Console.WriteLine();

        var cauB = from so in mangSo
                   where so <= 3
                   select so;

        Console.WriteLine("Cau b:");
        foreach (var so in cauB)
        {
            Console.Write(so + " ");
        }

        Console.WriteLine();



        var cauC = from so in mangSo
                   select so % 2 == 0 ? so / 2 : so;

        Console.WriteLine("Cau c:");
        foreach (var so in cauC)
        {
            Console.Write(so + " ");
        }
    }
}