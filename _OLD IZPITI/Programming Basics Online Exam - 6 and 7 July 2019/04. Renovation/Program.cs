using System;

namespace _04._Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int procent = int.Parse(Console.ReadLine());
            string litrePaintS = "0";
            double allArreaD = h * w * 4.0;
            allArreaD = allArreaD - allArreaD * procent * 1.0 / 100;
            double allArrea = Math.Floor(allArreaD);
            int paintedArrea = 0;
            int allPaintedArrea = 0;

            while (true)
            {
                litrePaintS = Console.ReadLine();

                if (litrePaintS == "Tired!")
                {
                    Console.WriteLine($"{allArrea - allPaintedArrea} quadratic m left.");
                    break;
                }
                paintedArrea = int.Parse(litrePaintS.ToString());
                allPaintedArrea += paintedArrea;

                if (allPaintedArrea == allArrea)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
                if (allPaintedArrea > allArrea)
                {
                    Console.WriteLine($"All walls are painted and you have {allPaintedArrea-allArrea} l paint left!");
                    break;
                }
            }
            
        }
    }
}
