using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (number <= 100)
            {
                bonus = 5.0;
            }
            else if (number > 100 && number <= 1000)
            {
                bonus = number * 20.0 / 100;
            }
            else if (number > 1000)
            {
                bonus = number * 10.0 / 100;
            }
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            if (number % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
