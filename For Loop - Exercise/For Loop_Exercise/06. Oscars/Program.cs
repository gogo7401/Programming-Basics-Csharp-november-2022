using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int countJudge = int.Parse(Console.ReadLine());

            double pontsActor = pointsAcademy;

            for (int i = 1; i <= countJudge; i++)
            {
                string nameJudge = Console.ReadLine();
                double pointsJudge = double.Parse(Console.ReadLine());
                pontsActor += nameJudge.Length * pointsJudge / 2;
                if (pontsActor > 1250.5) 
                { 
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {pontsActor:f1}!");
                    break;
                }
            }
            if (pontsActor <= 1250.5) { Console.WriteLine($"Sorry, {actor} you need {1250.5-pontsActor:f1} more!");}
        }
    }
}
