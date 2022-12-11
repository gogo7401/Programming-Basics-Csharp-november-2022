// 09. Yard Greening
using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());

            double cena= area * 7.61;
            double discount = cena * 0.18;
            double suma = cena - discount;
            Console.WriteLine($"The final price is: {suma} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}