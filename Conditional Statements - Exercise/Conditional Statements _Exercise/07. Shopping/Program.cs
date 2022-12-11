using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countGpu = int.Parse(Console.ReadLine());
            int countCpu = int.Parse(Console.ReadLine());
            int countRam = int.Parse(Console.ReadLine());

            double priceGpu = 250.00;
            double priceCpu = priceGpu * countGpu * 35.0 / 100;
            double priceRam = priceGpu * countGpu * 10.0 / 100;

            double priceSum = countGpu* priceGpu + countCpu* priceCpu + countRam* priceRam;

            if (countGpu > countCpu)
            {
                priceSum = priceSum - (priceSum * 15.0 / 100);
            }
            if (budget >= priceSum)
            {
                Console.WriteLine($"You have {(budget-priceSum):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(priceSum-budget):F2} leva more!");
            }
        }
    }
}
