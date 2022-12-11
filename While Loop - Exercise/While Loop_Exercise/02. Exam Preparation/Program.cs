using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failingGrades = int.Parse(Console.ReadLine());

            string NameExample = Console.ReadLine();    
            string grades = Console.ReadLine();

            int countFailingGrades = 0;
            int countGrades = 0;
            double sumGrades = 0.00;
            string lastExample ="";


            while (NameExample != "Enough")
            {
                sumGrades += double.Parse(grades);
                if (double.Parse(grades) <= 4.00) { countFailingGrades++; }
                if (countFailingGrades == failingGrades)
                {
                    Console.WriteLine($"You need a break, {countFailingGrades} poor grades.");
                    break;
                }
                NameExample = Console.ReadLine();
                countGrades++;
                if (NameExample != "Enough")
                {
                    grades = Console.ReadLine();
                    
                    lastExample = NameExample;
                }
                else
                {
                    Console.WriteLine($"Average score: {sumGrades / countGrades:f2}");
                    Console.WriteLine($"Number of problems: {countGrades}");
                    Console.WriteLine($"Last problem: {lastExample}");
                }
                


            }
            

        }

    }
}
