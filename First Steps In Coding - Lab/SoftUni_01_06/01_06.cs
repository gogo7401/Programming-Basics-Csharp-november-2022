// 06. Concatenate Data
using System;

namespace ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Въведете ИМЕ:");
            string firstName = Console.ReadLine();
            //Console.Write("Въведете ФАМИЛИЯ:");
            string lastName = Console.ReadLine();
            //Console.Write("Въведете ГОДИНИ:");
            int age = int.Parse(Console.ReadLine());
            //Console.Write("Въведете ГРАД:");
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
