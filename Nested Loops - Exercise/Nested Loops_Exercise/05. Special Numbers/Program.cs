using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool isSpecial;

            for (int i = 1111; i <= 9999; i++)
            {
                string s = i.ToString();
                isSpecial = false;
                for (int j = 0; j < s.Length; j++)
                {
                    if (int.Parse(s[j].ToString()) == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    else if (N % int.Parse(s[j].ToString()) != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    else isSpecial = true;
                }
                if (isSpecial) { Console.Write(i + " "); }
                
            }
        }
    }
}
