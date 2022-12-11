using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();

            string your_Password = Console.ReadLine();

            while (your_Password != password)
            {
                your_Password = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
