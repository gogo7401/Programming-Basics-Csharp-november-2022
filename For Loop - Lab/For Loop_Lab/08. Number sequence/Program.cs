using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = int.Parse(Console.ReadLine());
            int min = firstNumber;
            int max = firstNumber;

            for (int i = 1; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < min) { min = currentNumber; }
                if (currentNumber > max) { max = currentNumber; }

            }
            
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
