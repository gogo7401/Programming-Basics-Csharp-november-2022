using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countJury = int .Parse(Console.ReadLine());
            string namePresentation = Console.ReadLine();
            double studentAssessment = 0.00;
            double totalStudentAssessment = 0.00;
            double allStudentAssessment = 0.00;
            int countOfPresentations = 0;

            while (namePresentation!= "Finish")
            {
                countOfPresentations++;
                for (int i = 1; i <= countJury; i++)
                {
                    studentAssessment = double.Parse(Console.ReadLine());
                    totalStudentAssessment += studentAssessment;
                }
                Console.WriteLine($"{namePresentation} - {totalStudentAssessment/ countJury:f2}.");
                allStudentAssessment += totalStudentAssessment;
                totalStudentAssessment = 0.00;
                namePresentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {allStudentAssessment/ countOfPresentations/countJury:f2}.");
        }
    }
}
