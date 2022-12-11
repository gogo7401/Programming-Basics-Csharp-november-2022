using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            string pattern = "";
            if (floors == 1)
            {
                for (int i = 0; i < rooms; i++)
                {
                    pattern = pattern + "L"+floors+i.ToString() +" ";
                }
                Console.WriteLine(pattern);
            }
            else
            {
                for (int currentFloor = floors; currentFloor > 0; currentFloor--)
                {
                    pattern = "";
                    for (int currentRoom = 0; currentRoom < rooms; currentRoom++)
                    {
                        if(currentFloor == floors)
                        {
                            pattern = pattern + "L"+ currentFloor.ToString() + currentRoom.ToString() + " ";
                        }
                        else
                        {
                            if (currentFloor %2== 0)
                            {
                               pattern = pattern + "O" + currentFloor.ToString() + currentRoom.ToString() + " ";
                            }
                            else pattern = pattern + "A" + currentFloor.ToString() + currentRoom.ToString() + " ";
                        }
                        
                    }

                    Console.WriteLine(pattern);
                }
            }
        }
    }
}
