using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int sumTime = firstTime + secondTime + thirdTime;
            int minuti = sumTime / 60;
            int secundi = sumTime % 60;

            if (secundi > 9)
            {
                Console.WriteLine($"{minuti}:{secundi}");
            }
            else { Console.WriteLine($"{minuti}:0{secundi}"); }
        }
    }
}
