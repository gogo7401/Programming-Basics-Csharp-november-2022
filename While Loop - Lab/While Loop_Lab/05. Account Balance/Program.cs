using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string payment = Console.ReadLine();
            double sum = 0.00;

            while (payment != "NoMoreMoney")
            {
                if (double.Parse(payment) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {double.Parse(payment):f2}");
                sum += double.Parse(payment);
                payment = Console.ReadLine();

            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
