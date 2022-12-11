using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double timeRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine()); 
            double time1meter = double.Parse(Console.ReadLine());

            double delay = Math.Floor(distance / 15) * 12.5;
            double timeForDistance = distance * time1meter + delay;

            if (timeForDistance < timeRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeForDistance:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(timeForDistance- timeRecord):F2} seconds slower.");
            }
        }
    }
}
