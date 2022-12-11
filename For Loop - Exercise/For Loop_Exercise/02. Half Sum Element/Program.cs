using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int sumOtherNumbers = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max) { max = num; }
            }
            sumOtherNumbers = sum - max;
            if (sumOtherNumbers == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumOtherNumbers);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sumOtherNumbers-max));
            }
        }
    }
}
