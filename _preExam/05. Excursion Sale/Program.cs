using System;

namespace _05._Excursion_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seaCount = int.Parse(Console.ReadLine());
            int mountainCount  = int.Parse(Console.ReadLine());
            double profit = 0.00;

            while (true)
            {
                string packetName = Console.ReadLine();
                if (packetName == "Stop")
                {
                    break;
                }
                if (seaCount > 0 && packetName == "sea")
                {
                    profit += 680.00;
                    seaCount--;
                }
                if (mountainCount > 0 && packetName == "mountain")
                {
                    profit += 499.00;
                    mountainCount--;
                }
                if ((seaCount <= 0) && (mountainCount <= 0)) { break; }
            }
            if ((seaCount <= 0) && (mountainCount <= 0)) { Console.WriteLine("Good job! Everything is sold."); }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
