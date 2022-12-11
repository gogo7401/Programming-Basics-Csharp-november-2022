using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            bool workDay = false;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    workDay = true;
                    break;
                default: workDay = false; break;
            }
            if (workDay && hour >= 10 && hour <= 18)
            {
                Console.WriteLine("open");
            }
            else Console.WriteLine("closed");
        }
    }
}
