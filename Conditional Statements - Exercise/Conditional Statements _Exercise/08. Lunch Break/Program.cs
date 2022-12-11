using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int durationepisode = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());


            double timeLunch = durationBreak / 8.0;
            double timeRelax = durationBreak / 4.0;

            if ((durationBreak - timeLunch - timeRelax) >= durationepisode)
            {
                Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(durationBreak-timeLunch-timeRelax-durationepisode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(Math.Abs(durationBreak - timeLunch - timeRelax - durationepisode))} more minutes.");
            }
        }
    }
}
