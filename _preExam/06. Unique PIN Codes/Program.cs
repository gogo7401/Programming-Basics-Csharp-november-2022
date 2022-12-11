using System;

namespace _06._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit  = int.Parse(Console.ReadLine());
            bool isSimpleNumber = true;

            for (int one = 2; one <= firstDigit; one+=2)
            {

                if (secondDigit > 7) { secondDigit = 7; }   
                for (int two = 2; two <= secondDigit; two++)
                    {
                        isSimpleNumber = true;
                        for (int i = 2; i < two; i++)
                        {
                            if (two % 2 == 0) { isSimpleNumber = false; }
                        }
                        if (isSimpleNumber) 
                        {
                        for (int three = 2; three <= thirdDigit; three += 2)
                        {
                            Console.WriteLine($"{one} {two} {three}");
                        }
                        }
                    }

            }
        }
    }
}
