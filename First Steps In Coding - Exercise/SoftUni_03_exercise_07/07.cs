// 07

using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pile = int.Parse(Console.ReadLine());
            int riba = int.Parse(Console.ReadLine());
            int vega = int.Parse(Console.ReadLine());


            double sumaMenu = pile * 10.35 + riba * 12.40 + vega * 8.15;
            double sumaDesert = sumaMenu * 20 / 100;
            double suma = sumaMenu + sumaDesert + 2.50;

            Console.WriteLine(suma);
           
        }
    }
}