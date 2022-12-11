using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int studentClass = 0;
            double assessment;
            int bad = 0;
            double sum = 0.00;

            while (studentClass < 12)
            {
                studentClass++;
                assessment = double.Parse(Console.ReadLine());
                if (assessment < 4.0) { bad++; }
                if (bad > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {studentClass-1} grade");
                    break;
                }
                sum += assessment;
                if (studentClass == 12) { Console.WriteLine($"{name} graduated. Average grade: {sum/studentClass:f2}"); }

            }
        }
    }
}
