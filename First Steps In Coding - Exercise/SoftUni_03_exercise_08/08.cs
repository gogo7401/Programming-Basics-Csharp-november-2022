// 08

using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taksa = int.Parse(Console.ReadLine());

            double kecove = taksa - taksa * 40 / 100;
            double ekip = kecove - kecove * 20 / 100;
            double topka = ekip / 4;
            double aksesoari = topka / 5;



            double suma = taksa + kecove + ekip + topka + aksesoari;

            Console.WriteLine(suma);
        }
    }
}