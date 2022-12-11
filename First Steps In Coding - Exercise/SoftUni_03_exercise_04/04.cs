// 04

using System;

namespace VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int straniciKniga = int.Parse(Console.ReadLine());
            int straniciZaChas = int.Parse(Console.ReadLine());
            int broiDni = int.Parse(Console.ReadLine());

            double broiChasove = straniciKniga / broiDni / straniciZaChas;
            Console.WriteLine(broiChasove);
        }
    }
}