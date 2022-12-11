using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            string type = "";

            switch (operation)
            {
                case "+":
                    if ((N1 + N2) % 2 == 0)
                    {
                        type = "even";
                    }
                    else type = "odd";
                    Console.WriteLine($"{N1} + {N2} = {N1 + N2} - {type}");
                    break;
                case "-":
                    if ((N1 - N2) % 2 == 0)
                    {
                        type = "even";
                    }
                    else type = "odd";
                    Console.WriteLine($"{N1} - {N2} = {N1 - N2} - {type}");
                    break;
                case "*":
                    if ((N1 * N2) % 2 == 0)
                    {
                        type = "even";
                    }
                    else type = "odd";
                    Console.WriteLine($"{N1} * {N2} = {N1 * N2} - {type}");
                    break;
                case "/":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else Console.WriteLine($"{N1} / {N2} = {N1 * 1.0 / N2:f2}");
                    break;
                case "%":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                    break;
            }

        }
    }
}
