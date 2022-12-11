using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int next = int.Parse(Console.ReadLine());
            int sum = next;

            while (sum < first)
            {
                next = int.Parse(Console.ReadLine());
                sum += next;
            }
            Console.WriteLine(sum);
        }
    }
}
