using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            int countSpend = 0;
            int countDay = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double moneyAction = double.Parse(Console.ReadLine());
                countDay++;
                if (action == "spend")  
                {
                    countSpend++;
                    moneyOnHand -= moneyAction;
                    if (moneyOnHand < 0) { moneyOnHand = 0; }
                }
                else { countSpend = 0; }
                if (action == "save")  
                {
                    moneyOnHand += moneyAction;
                }
                if (countSpend == 5)  // Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countDay);
                    break;
                }
                if (moneyOnHand >= moneyNeeded) // Ако Джеси събере парите за почивката на конзолата се изписва:
                {
                    Console.WriteLine($"You saved the money for {countDay} days.");
                    break;
                }
                
            }
        }
    }
}
