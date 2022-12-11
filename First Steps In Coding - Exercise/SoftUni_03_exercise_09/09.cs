// 09

using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double obem = (d * w * h);  // v cm3
            double litri = obem / 1000;  // v litri
            
            double voda = litri * (1 - procent/100); // izvazdame procenta zaeto myasto
            Console.WriteLine(voda);
        }
    }
}