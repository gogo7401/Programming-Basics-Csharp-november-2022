using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string typeOfFlowers = Console.ReadLine();
            int countFlower = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceRoses = 5.00;
            double priceDahlias = 3.80;
            double priceTulips = 2.80;
            double priceNarcissus = 3.00;
            double priceGladiolus = 2.50;
            double price = 0.00;


            switch (typeOfFlowers)
            {
                case "Roses":
                    if (countFlower > 80)
                    {
                        price = priceRoses - priceRoses * 10.0 / 100;
                    }
                    else price = priceRoses;
                    break;
                case "Dahlias":
                    if (countFlower > 90)
                    {
                        price = priceDahlias - priceDahlias * 15.0 / 100;
                    }
                    else price = priceDahlias;
                    break;
                case "Tulips":
                    if (countFlower > 80)
                    {
                        price = priceTulips - priceTulips * 15.0 / 100;
                    }
                    else price = priceTulips;
                    break;
                case "Narcissus":
                    if (countFlower < 120)
                    {
                        price = priceNarcissus + priceNarcissus * 15.0 / 100;
                    }
                    else price = priceNarcissus;
                    break;
                case "Gladiolus":
                    if (countFlower < 80)
                    {
                        price = priceGladiolus + priceGladiolus * 20.0 / 100;
                    }
                    else price = priceGladiolus;   
                    break;

            }
            price *= countFlower;
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlower} {typeOfFlowers} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
