using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wCake = int.Parse(Console.ReadLine());
            int hCake = int.Parse(Console.ReadLine());

            int cakePiece = wCake * hCake;

            string takePieceOfCake = Console.ReadLine();

            while (takePieceOfCake != "STOP")
            {
                cakePiece -= int.Parse(takePieceOfCake);
                if (cakePiece < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePiece)} pieces more.");
                    break;
                }
                takePieceOfCake = Console.ReadLine();
            }
            if (cakePiece >= 0)
            {
                Console.WriteLine($"{cakePiece} pieces are left.");
            }
        }
    }
}
