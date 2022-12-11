// 04. InchestoCentimeters
using System;

namespace InchestoCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i = double.Parse(Console.ReadLine());
            double c = i * 2.54;

            Console.WriteLine(c);
        }
    }
}