// 07. Projects Creation
using System;

namespace ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ArhName = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());
            int h = broi * 3;
            Console.WriteLine($"The architect {ArhName} will need {h} hours to complete {broi} project/s.");
        }
    }
}
