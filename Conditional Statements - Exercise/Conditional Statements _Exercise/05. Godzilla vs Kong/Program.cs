using System;

namespace _05._Godzilla_vs_Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countActor = int.Parse(Console.ReadLine());
            double priceClothing = double.Parse(Console.ReadLine());

            double decor = budget * 10.0 / 100;
            double sumActor = countActor * priceClothing;
            if (countActor > 150)
            {
                sumActor = sumActor - (sumActor * 10.0 / 100); 
            }
            double cost = sumActor + decor;
            double difference = budget - cost;

            if (difference < 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }
        }
    }
}
