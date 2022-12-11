using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                string currentNumber = i.ToString();
                int lengthNumber = currentNumber.Length;

                int sumEven = 0;
                int sumOdd = 0;

                for (int j = 0; j < lengthNumber; j++)
                {
                    if ((j+1) % 2 == 0)
                    {
                        sumEven = sumEven + int.Parse(currentNumber[j].ToString());
                    }
                    else sumOdd = sumOdd + int.Parse(currentNumber[j].ToString());
                }
                if (sumEven == sumOdd)
                {
                    Console.Write(currentNumber + " ");
                }

            }
            

        }
    }
}
