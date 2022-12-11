using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countTabs; i++)
            {
                string tabName = Console.ReadLine();
                if (tabName == "Facebook")
                {
                    salary -= 150;
                }
                if (tabName == "Instagram")
                {
                    salary -= 100;
                }
                if (tabName == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0) { Console.WriteLine(salary); }
        }
    }
}
