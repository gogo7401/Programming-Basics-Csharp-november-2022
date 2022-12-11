using System;

namespace _04._Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studensCount = int.Parse(Console.ReadLine());
            double examGrade = 0.00;
            double allExamGrade = 0.00;
            int examGrade2 = 0;
            int examGrade3 = 0;
            int examGrade4 = 0;
            int examGrade5 = 0;

            for (int i = 0; i < studensCount; i++)
            {
                examGrade = double.Parse(Console.ReadLine());
                allExamGrade += examGrade;
                if (examGrade >= 2 && examGrade <= 2.99) { examGrade2++; }
                if (examGrade >= 3 && examGrade <= 3.99) { examGrade3++; }
                if (examGrade >= 4 && examGrade <= 4.99) { examGrade4++; }
                if (examGrade >= 5 && examGrade <= 6.00) { examGrade5++; }
            }
            Console.WriteLine($"Top students: {examGrade5 * 1.0 / studensCount * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {examGrade4 * 1.0 / studensCount * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {examGrade3 * 1.0 / studensCount * 100:f2}%");
            Console.WriteLine($"Fail: {examGrade2 * 1.0 / studensCount * 100:f2}%");
            Console.WriteLine($"Average: {allExamGrade/studensCount:f2}");
        }
    }
}
