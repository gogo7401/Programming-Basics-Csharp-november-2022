using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double savedMoney = 0;
                double tripCost = double.Parse(Console.ReadLine());

                while (savedMoney<tripCost)
                {
                    double pay = double.Parse(Console.ReadLine());
                    savedMoney += pay;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
