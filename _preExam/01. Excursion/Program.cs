using System;

namespace _01._Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            int nightCount = int.Parse(Console.ReadLine()); 
            int cardCount = int.Parse(Console.ReadLine());  
            int ticketsMuseum = int.Parse(Console.ReadLine());

            double nightPrices = nightCount * 20.0;
            double cardPrices = cardCount * 1.60;
            double ticketMuseumPrices = ticketsMuseum * 6.0;
            double totalSum = (nightPrices + cardPrices + ticketMuseumPrices) * peoples;
            totalSum *= 1.25;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
