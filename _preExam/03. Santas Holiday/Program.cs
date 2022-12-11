using System;

namespace _03._Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int nightCount = dayCount - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double nightsPrice = 0.00;

            switch (roomType)
            {
                case "room for one person":
                    nightsPrice = nightCount * 18.0;
                    break;
                case "apartment":
                    if (nightCount < 10)
                    {
                        nightsPrice = nightCount * 25.00;
                        nightsPrice = nightsPrice - nightsPrice * 0.30;
                    }
                    if (nightCount >= 10 && nightsPrice <= 15)
                    {
                        nightsPrice = nightCount * 25.00;
                        nightsPrice = nightsPrice - nightsPrice * 0.35;
                    }
                    if (nightCount > 15)
                    {
                        nightsPrice = nightCount * 25.00;
                        nightsPrice = nightsPrice - nightsPrice * 0.50;
                    }
                    break;
                case "president apartment":
                    if (nightCount < 10)
                    {
                        nightsPrice = nightCount * 35.00;
                        nightsPrice = nightsPrice - nightsPrice * 0.10;
                    }
                    if (nightCount >= 10 && nightsPrice <= 15)
                    {
                        nightsPrice = nightCount * 35.00;
                        nightsPrice = nightsPrice - nightsPrice * 0.15;
                    }
                    if (nightCount > 15)
                    {
                        nightsPrice = nightCount * 35.00;
                        nightsPrice = nightsPrice - nightsPrice * 0.20;
                    }
                    break;
            }
            if (rating == "positive")
            {
                nightsPrice = nightsPrice + nightsPrice * 0.25;
            }
            else
            {
                nightsPrice = nightsPrice - nightsPrice * 0.10;
            }
            Console.WriteLine($"{nightsPrice:f2}");
        }
    }
}
