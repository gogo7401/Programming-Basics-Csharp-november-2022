using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            string vid = Console.ReadLine();
            if (vid == "square") 
            { 
                double a = double.Parse(Console.ReadLine());
                double s = a * a;
                Console.WriteLine($"{s:F3}");
            }
            if (vid == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = a * b;
                Console.WriteLine($"{s:F3}");
            }
            if (vid == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double s = Math.PI * r * r;
                Console.WriteLine($"{s:F3}");
            }
            if (vid == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double s = a * h / 2;
                Console.WriteLine($"{s:F3}");
            }
        }
    }
}
