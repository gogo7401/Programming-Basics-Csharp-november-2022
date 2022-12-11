using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wApp = int.Parse(Console.ReadLine());
            int hApp = int.Parse(Console.ReadLine());
            int dApp = int.Parse(Console.ReadLine());

            int vApp = wApp * hApp * dApp;
            string countPacket = Console.ReadLine();

            while (countPacket != "Done")
            {
                vApp -= int.Parse(countPacket);
                if (vApp < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(vApp)} Cubic meters more.");
                    break;
                }
                countPacket = Console.ReadLine();
            }
            if (vApp >= 0)
            {
                Console.WriteLine($"{vApp} Cubic meters left.");
            }
        }
    }
}
