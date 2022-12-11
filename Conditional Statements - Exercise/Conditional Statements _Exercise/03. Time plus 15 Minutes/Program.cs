using System;

namespace _03._Time_plus_15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());   
            int minute = int.Parse(Console.ReadLine());

            minute += 15;
            if (minute < 60)
            {
                if (minute < 10)
                {
                    Console.WriteLine($"{hour}:0{minute}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minute}");
                }
                
            }
            else 
            {
                minute -= 60;
                hour += 1;
                if (hour > 23)
                {
                    hour -= 24;
                }
                if (minute < 10)
                {
                    Console.WriteLine($"{hour}:0{minute}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minute}");
                }
            }
        }
    }
}
