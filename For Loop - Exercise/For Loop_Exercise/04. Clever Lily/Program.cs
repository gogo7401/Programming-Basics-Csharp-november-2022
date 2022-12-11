using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageLili = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int countToy = 0;
            double money = 0.0;

            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 == 0)
                {
                    money += i*5 - 1;
                }
                else { countToy++; }
            }
            money += countToy * priceToy;
            double N = money-priceWashingMachine;
            double M = priceWashingMachine-money;
            if (money >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {N:f2}");
            }
            else Console.WriteLine($"No! {M:f2}");
        }
    }
}
