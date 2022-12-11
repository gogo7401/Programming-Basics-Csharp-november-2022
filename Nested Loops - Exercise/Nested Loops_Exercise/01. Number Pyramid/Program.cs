using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastNumber = 0;
            int line = 0;
            string pattern = "";
            int beginNumber = 1;

            while (lastNumber < n)
            {
                line++;
                beginNumber = lastNumber + 1;
                lastNumber = lastNumber + line;
                for (int i = beginNumber; i <= lastNumber; i++)
                {
                    pattern = pattern + i.ToString() + " ";
                   if (i == n)
                    {
                        break;
                    }
                }
                Console.WriteLine(pattern);
                pattern = "";
            }
        }
    }
}
