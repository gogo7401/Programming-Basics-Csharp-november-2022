using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string raiting = Console.ReadLine();

            double price = 0.00;

            days--;  // Отстъпка за дни 3=2, 2=1, 1=0 и т.н.
            switch (typeRoom)
            {
                case "room for one person":
                    price = 18.00;
                    break;
                case "apartment":
                    price = 25.00;
                    if (days < 10)
                    {
                        price = price - price * 30.0 / 100;
                    }
                    else if (days >=10 && days <= 15)
                    {
                        price = price - price * 35.0 / 100;
                    }
                    else if (days > 15)
                    {
                        price = price - price * 50.0 / 100;
                    }
                    break;
                case "president apartment":
                    price = 35.00;
                    if (days < 10)
                    {
                        price = price - price * 10.0 / 100;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = price - price * 15.0 / 100;
                    }
                    else if (days > 15)
                    {
                        price = price - price * 20.0 / 100;
                    }
                    break;
            }
            if (raiting == "positive")
            {
                Console.WriteLine($"{price * days * 1.25:f2}");
            }
            else Console.WriteLine($"{price*days*0.90:f2}");
        }
    }
}
