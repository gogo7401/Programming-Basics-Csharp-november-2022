using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());   
            string season = Console.ReadLine();

            string destination = "";
            string type = "";
            double price = 0.00;


            if (budget <= 100) // Bulgaria
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        price = budget * 30.0 / 100;
                        type = "Camp";
                        break;
                    case "winter":
                        price = budget * 70.0 / 100;
                        type = "Hotel";
                        break;
                }
                    

            }
            else if (budget>100 && budget <= 1000)  // Balkans
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        price = budget * 40.0 / 100;
                        type = "Camp";
                        break;
                    case "winter":
                        price = budget * 80.0 / 100;
                        type = "Hotel";
                        break;
                }
            }
            else if (budget > 1000)  // Europe
            {
                destination = "Europe";
                price = budget * 90.0 / 100;
                type = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
