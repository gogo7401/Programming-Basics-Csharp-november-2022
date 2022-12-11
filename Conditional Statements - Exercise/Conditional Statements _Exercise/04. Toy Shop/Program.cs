using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int countPuzzle  = int.Parse(Console.ReadLine());
            int countDoll = int.Parse(Console.ReadLine());
            int countBear = int.Parse(Console.ReadLine());
            int countMinion = int.Parse(Console.ReadLine());
            int countTruck = int.Parse(Console.ReadLine());

            double pricePuzzle = 2.60;
            double priceDoll = 3.00;
            double priceBear = 4.10;
            double priceMinion = 8.20;
            double priceTruck = 2.00;

            int sumToys = countPuzzle + countDoll + countBear + countMinion + countTruck;
            double sumPrice = countPuzzle* pricePuzzle + countDoll* priceDoll + countBear* priceBear + countMinion* priceMinion + countTruck* priceTruck;
            double discount = 0.0;
            if (sumToys >= 50)
            {
                discount = sumPrice * 25.0 / 100;
            }
            double profit = (sumPrice - discount) - (sumPrice - discount) * 10.0 / 100;

            if (profit >= priceTrip)
            {
                Console.WriteLine($"Yes! {(profit - priceTrip):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(Math.Abs(priceTrip-profit)):F2} lv needed.");
            }

        }
    }
}
