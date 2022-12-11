using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TargetBook = Console.ReadLine();
            string CurrentBook = Console.ReadLine();

            int countCheckedBooks = 0;
            bool isFindBook = false;

            while (CurrentBook != "No More Books")
            {
                
                if (TargetBook == CurrentBook)
                {
                    isFindBook = true;
                    break;
                }
                CurrentBook = Console.ReadLine();
                countCheckedBooks++;
            }
            if (isFindBook) { Console.WriteLine($"You checked {countCheckedBooks} books and found it."); }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countCheckedBooks} books.");
            }


        }
    }
}
