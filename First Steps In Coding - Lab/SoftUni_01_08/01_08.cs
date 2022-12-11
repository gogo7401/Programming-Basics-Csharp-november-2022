// 08.Pet Shop
using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());
            double doglv = dog * 2.50;
            double catlv = cat * 4.00;
            double suma = doglv + catlv;
            Console.WriteLine($"{suma} lv.");
        }
    }
}