using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTournament = int.Parse(Console.ReadLine());
            int pontsBegin = int.Parse(Console.ReadLine());

            int pointsTournament = 0;
            int winner = 0;

            for (int i = 1; i <= countTournament; i++)
            {
                string roundTournament = Console.ReadLine();
                if (roundTournament == "W")
                {
                    pointsTournament += 2000;
                    winner ++;
                }
                else if (roundTournament == "F")
                {
                    pointsTournament += 1200;
                }
                else if (roundTournament == "SF")
                {
                    pointsTournament += 720;
                }
            }
            Console.WriteLine($"Final points: {pontsBegin + pointsTournament}");
            Console.WriteLine($"Average points: {Math.Floor(pointsTournament * 1.0 / countTournament)}");
            Console.WriteLine($"{(100.0/countTournament*winner):f2}%");
        }
    }
}
