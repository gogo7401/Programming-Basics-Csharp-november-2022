using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int budget = int.Parse(Console.ReadLine()); 
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            
            double priceShip = 0.0;

            switch (season)
            {
                case "Spring":
                    priceShip = 3000.00;
                    if (count <= 6)
                    {
                        priceShip = priceShip - priceShip * 10.0 / 100;
                    }
                    else if (count >= 7 && count <= 11)
                    {
                        priceShip = priceShip - priceShip * 15.0 / 100;
                    }
                    else if (count >= 12)
                    {
                        priceShip = priceShip - priceShip * 25.0 / 100;
                    }
                    if (count % 2 == 0)
                    {
                        priceShip = priceShip - priceShip * 5.0 / 100;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    priceShip = 4200.00;
                    if (count <= 6)
                    {
                        priceShip = priceShip - priceShip * 10.0 / 100;
                    }
                    else if (count >= 7 && count <= 11)
                    {
                        priceShip = priceShip - priceShip * 15.0 / 100;
                    }
                    else if (count >= 12)
                    {
                        priceShip = priceShip - priceShip * 25.0 / 100;
                    }
                    if (count % 2 == 0 && season == "Summer")
                    {
                        priceShip = priceShip - priceShip * 5.0 / 100;
                    }
                    break;
                case "Winter":
                    priceShip = 2600.00;
                    if (count <= 6)
                    {
                        priceShip = priceShip - priceShip * 10.0 / 100;
                    }
                    else if (count >= 7 && count <= 11)
                    {
                        priceShip = priceShip - priceShip * 15.0 / 100;
                    }
                    else if (count >= 12)
                    {
                        priceShip = priceShip - priceShip * 25.0 / 100;
                    }
                    if (count % 2 == 0)
                    {
                        priceShip = priceShip - priceShip * 5.0 / 100;
                    }
                    break;

            }
            if (budget >= priceShip)
            {
                Console.WriteLine($"Yes! You have {budget - priceShip:f2} leva left.");
            }
            else Console.WriteLine($"Not enough money! You need {priceShip - budget:f2} leva.");

        }
    }
}
