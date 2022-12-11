// 06

using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boya = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());

            double sumaMateriali = (nailon + 2) * 1.50 + (boya * 1.1) * 14.50 + razreditel * 5.00 + 0.40;
            double sumaZaplata = (sumaMateriali * 30 / 100) * chasove;
            double suma = sumaMateriali + sumaZaplata;
            Console.WriteLine($"{suma:F2}");
        }
    }
}