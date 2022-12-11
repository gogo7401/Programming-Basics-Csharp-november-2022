// 05

using System;

namespace SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int himikali = int.Parse(Console.ReadLine());
            int markeri = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            int namalenie = int.Parse(Console.ReadLine());

            double suma = himikali * 5.80 + markeri * 7.20 + preparat * 1.20;
            double otstypka = suma * namalenie / 100;
            Console.WriteLine(suma - otstypka);
        }
    }
}