using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;
            int numer;

            while (input != "Stop")
            {
                numer = int.Parse(input);
                if (numer < minNumber) { minNumber = numer; }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
