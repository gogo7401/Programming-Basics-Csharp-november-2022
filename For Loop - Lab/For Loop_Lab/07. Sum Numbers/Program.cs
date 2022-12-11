using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                //int current = int.Parse(Console.ReadLine());
                //sum+=current;
                sum+= int.Parse(Console.ReadLine());

            }
            
            Console.WriteLine(sum);
        }
    }
}
