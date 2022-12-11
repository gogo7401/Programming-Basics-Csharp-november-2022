using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double priceStudio = 0.00;
            double priceApp = 0.00;


            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50.00;
                    priceApp = 65.00;
                    if (count > 7 && count <= 14)
                    {
                        priceStudio = priceStudio - priceStudio * 5.0 / 100;
                    }
                    if (count > 14 )
                    {
                        priceStudio = priceStudio - priceStudio * 30.0 / 100;
                        priceApp = priceApp - priceApp * 10.0 / 100;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApp = 68.70;
                    if (count > 14)
                    {
                        priceStudio = priceStudio - priceStudio * 20.0 / 100;
                        priceApp = priceApp - priceApp * 10.0 / 100;
                    }
                    break;
                case "July":
                case "August":
                    priceStudio = 76.00;
                    priceApp = 77.00;
                    if (count > 14)
                    {
                        priceApp = priceApp - priceApp * 10.0 / 100;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {priceApp*count:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio*count:f2} lv.");
        }
    }
}
