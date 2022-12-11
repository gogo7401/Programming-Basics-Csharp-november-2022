// 03

using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());

            double suma = deposit + srok * ((deposit * lihva/100) / 12);
            Console.WriteLine(suma);
        }
    }
}