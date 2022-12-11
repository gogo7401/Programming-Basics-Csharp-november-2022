using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            bool isPrime = true;

            while (input !="stop")
            {
                int currentNumber = int.Parse(input.ToString());
                
                if (currentNumber>0)
                {
                    for (int i = 2; i < currentNumber; i++)
                    {
                        if (currentNumber % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        sumPrime += currentNumber;
                    }
                    else sumNonPrime += currentNumber;
                }
                else
                {
                    if (currentNumber < 0)
                    {
                        Console.WriteLine("Number is negative.");
                    } 
                }
                input = Console.ReadLine();
                isPrime = true;
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
