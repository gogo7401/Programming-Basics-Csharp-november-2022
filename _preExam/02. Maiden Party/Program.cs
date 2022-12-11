using System;

namespace _02._Maiden_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveMessagesCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int keyHolderCount = int.Parse(Console.ReadLine());
            int cartoonsCount = int.Parse(Console.ReadLine());
            int luckCount = int.Parse(Console.ReadLine());

            double loveMessagesSum = loveMessagesCount * 0.60;
            double rosesSum = rosesCount * 7.20;
            double keyHolderSum = keyHolderCount * 3.60;
            double cartoonsSum = cartoonsCount * 18.20;
            double luckSum = luckCount * 22.0;
            double totalSum = loveMessagesSum + rosesSum + keyHolderSum + cartoonsSum + luckSum;
            int totalCount = loveMessagesCount + rosesCount + keyHolderCount + cartoonsCount + luckCount;

            if (totalCount >= 25)
            {
                totalSum = totalSum - totalSum * 0.35;
            }
            totalSum = totalSum - totalSum * 0.10;

            if (totalSum >= partyPrice)
            {
                Console.WriteLine($"Yes! {totalSum-partyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {partyPrice-totalSum:f2} lv needed.");
            }
        }
    }
}
