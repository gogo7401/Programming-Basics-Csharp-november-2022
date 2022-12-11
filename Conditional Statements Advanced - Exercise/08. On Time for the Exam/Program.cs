using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());
            int hArrive = int.Parse(Console.ReadLine());
            int mArrive = int.Parse(Console.ReadLine());

            int tExam = hExam * 60 + mExam;
            int tArrive = hArrive * 60 + mArrive;

            string onTime = "";
            int difference = 0;
            int hDiff = 0;
            int mDiff = 0;

            if (tExam - tArrive <= 30 && tExam > tArrive)
            {
                onTime = "On time";
            }
            if (tArrive - tExam > 0)
            {
                onTime = "Late";
            }
            if (tExam - tArrive > 30)
            {
                onTime = "Early";
            }
            // отпечатва
            difference = Math.Abs(tExam - tArrive);
            if (difference == 0)
            {
                Console.WriteLine("On time");
            }
            switch (onTime)
            {
                case "Late":
                    if (difference > 59)
                    {
                        hDiff = difference / 60;
                        mDiff = difference % 60;
                        Console.WriteLine(onTime);
                        if (mDiff < 10)
                        {
                            Console.WriteLine($"{hDiff}:0{mDiff} hours after the start");
                        }
                        else Console.WriteLine($"{hDiff}:{mDiff} hours after the start");
                    }
                    else
                    {
                        mDiff = difference;
                        Console.WriteLine(onTime);
                        Console.WriteLine($"{mDiff} minutes after the start");
                    }
                    break;
                case "On time":
                    mDiff = difference;
                    Console.WriteLine(onTime);
                    Console.WriteLine($"{mDiff} minutes before the start");
                    break;
                case "Early":
                    if (difference > 59)
                    {
                        hDiff = difference / 60;
                        mDiff = difference % 60;
                        Console.WriteLine(onTime);
                        if (mDiff < 10)
                        {
                            Console.WriteLine($"{hDiff}:0{mDiff} hours before the start");
                        }
                        else Console.WriteLine($"{hDiff}:{mDiff} hours before the start");
                    }
                    else
                    {
                        mDiff = difference;
                        Console.WriteLine(onTime);
                        Console.WriteLine($"{mDiff} minutes before the start");
                    }
                    break;

            }
        }
    }
}
