using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int totalSteps = 0;

            while (steps != "Going home")
            {
                totalSteps += int.Parse(steps);
                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps-10000} steps over the goal!");
                    break;
                }
                steps = Console.ReadLine();
            }
            if (steps == "Going home")
            {
                steps = Console.ReadLine();
                totalSteps += int.Parse(steps);
                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{10000-totalSteps} more steps to reach goal.");
                }

            }
            

        }
    }
}
