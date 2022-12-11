// 02

using System;

namespace USDtoRadianstoDegreesBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double gradusi = radian * 180 / Math.PI;
            Console.WriteLine(gradusi);
        }
    }
}