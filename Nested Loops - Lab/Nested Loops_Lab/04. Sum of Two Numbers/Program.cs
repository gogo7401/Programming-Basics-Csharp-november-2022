using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leftInterval = int.Parse(Console.ReadLine());   
            int rightInterval = int.Parse(Console.ReadLine());  
            int magicNumber  = int.Parse(Console.ReadLine());

            int sum = 0;
            bool isValidCombination = false;
            int counter = 0;

            for (int leftNumber = leftInterval; leftNumber <= rightInterval; leftNumber++)
            {
                for (int rightNumber = leftInterval; rightNumber <= rightInterval; rightNumber++)
                {
                    counter++;  
                    sum = leftNumber + rightNumber;
                    if (sum == magicNumber)
                    {
                        isValidCombination = true;
                        Console.WriteLine($"Combination N:{counter} ({leftNumber} + {rightNumber} = {sum})");
                        break;
                    }
                }
                if (isValidCombination == true)
                {
                    break;
                }
            }
            if (isValidCombination == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
