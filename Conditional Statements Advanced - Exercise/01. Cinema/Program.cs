using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();   
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double Premiere = 12.00;
            double Normal = 7.50;
            double Discount = 5.00;
            double income = 0.00;

            switch (type)
            {
                case "Premiere": income = row * col * Premiere; break;
                case "Normal": income = row * col * Normal; break;
                case "Discount": income = row * col * Discount; break;
            }

            Console.WriteLine($"{income:f2}\nleva");
        }
    }
}
