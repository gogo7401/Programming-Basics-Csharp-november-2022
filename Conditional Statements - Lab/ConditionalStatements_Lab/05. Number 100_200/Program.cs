﻿using System;

namespace _05._Number_100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            int num = int.Parse(Console.ReadLine());

            //output
            if (num < 100) { Console.WriteLine("Less than 100"); }
            if (num >= 100 && num <= 200) { Console.WriteLine("Between 100 and 200"); }
            if (num > 200) { Console.WriteLine("Greater than 200"); }
        }
    }
}
