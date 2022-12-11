using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;
            int numer;

            while (input != "Stop")
            {
                numer = int.Parse(input);
                if (numer > maxNumber) { maxNumber = numer; }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
