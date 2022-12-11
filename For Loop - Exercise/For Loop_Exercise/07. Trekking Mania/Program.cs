using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countGroups = int.Parse(Console.ReadLine());

            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 1; i <= countGroups; i++)
            {
                int countClimbers = int.Parse(Console.ReadLine());
                if (countClimbers <= 5) { musala += countClimbers; }
                if (countClimbers >= 6 && countClimbers <= 12) { monblan += countClimbers; }
                if (countClimbers >= 13 && countClimbers <= 25) { kilimandjaro += countClimbers; }
                if (countClimbers >= 26 && countClimbers <= 40) { k2 += countClimbers; }
                if (countClimbers >= 41) { everest += countClimbers; }
            }
            int sumClimbers = musala + monblan + kilimandjaro + k2 + everest;
            Console.WriteLine($"{100.0 / sumClimbers * musala:f2}%");
            Console.WriteLine($"{100.0 / sumClimbers * monblan:f2}%");
            Console.WriteLine($"{100.0 / sumClimbers * kilimandjaro:f2}%");
            Console.WriteLine($"{100.0 / sumClimbers * k2:f2}%");
            Console.WriteLine($"{100.0 / sumClimbers * everest:f2}%");
        }
    }
}
