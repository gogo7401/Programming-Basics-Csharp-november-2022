using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200) { p1++; }
                else if (num >= 200 && num<=399) { p2++; }
                else if (num >= 400 && num <= 599) { p3++; }
                else if (num >= 600 && num <= 799) { p4++; }
                else if (num >= 800) { p5++; }
            }
            int p = p1 + p2 + p3 + p4 + p5;
            Console.WriteLine($"{(100.0/p*p1):f2}%");
            Console.WriteLine($"{(100.0 / p * p2):f2}%");
            Console.WriteLine($"{(100.0 / p * p3):f2}%");
            Console.WriteLine($"{(100.0 / p * p4):f2}%");
            Console.WriteLine($"{(100.0 / p * p5):f2}%");
        }
    }
}
