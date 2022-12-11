using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double changeMoney = double.Parse(Console.ReadLine());

            int countCoin = 0;
            changeMoney *= 100;

            while (changeMoney >= 200)  // 2 leva
            {
                changeMoney -= 200;
                countCoin++;
            }
            while (changeMoney >= 100) // 1 lev
            {
                changeMoney -= 100;
                countCoin++;
            }
            while (changeMoney >= 50)  // 50 stotinki
            {
                changeMoney -= 50;
                countCoin++;
            }
            while (changeMoney >= 20)  // 20 stotinki
            {
                changeMoney -= 20;
                countCoin++;
            }
            while (changeMoney >= 10) // 10 stotinki
            {
                changeMoney -= 10;
                countCoin++;
            }
            while (changeMoney >= 5)  // 5 stotinki
            {
                changeMoney -= 5;
                countCoin++;
            }
            while (changeMoney >= 2) // 2 stotinki
            {
                changeMoney -= 2;
                countCoin++;
            }
            while (changeMoney >= 1)  // 1 stotinka
            {
                changeMoney -= 1;
                countCoin++;
            }
            Console.WriteLine(countCoin);
        }
    }
}
