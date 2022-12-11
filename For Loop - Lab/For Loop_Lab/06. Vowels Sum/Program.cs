using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                switch (c)
                {
                    case 'a':
                        count += 1; 
                        break;
                    case 'e':
                        count += 2;
                        break;
                    case 'i':
                        count += 3;
                        break;
                    case 'o':
                        count += 4;
                        break;
                    case 'u':
                        count += 5;
                        break;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
