using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            //int freeSeat = int.Parse(Console.ReadLine());
            int countTicketStudent = 0;
            int countTicketStandard = 0;
            int countTicketKid = 0;
            int busySeat = 0;

            while (filmName != "Finish")
            {
                
                int freeSeat = int.Parse(Console.ReadLine());
                
                
                while (busySeat < freeSeat)
                {
                    string typeTicket = Console.ReadLine();
                    if (typeTicket != "End")
                    {
                        switch (typeTicket)
                        {
                            case "student": countTicketStudent++; break;
                            case "standard": countTicketStandard++; break;
                            case "kid": countTicketKid++; break;
                        }
                        busySeat++;
                    }
                    else break;
                 }
                double procentBusySeat = busySeat *1.0/ freeSeat * 100;
                Console.WriteLine($"{filmName} - {procentBusySeat:f2}% full.");
                busySeat = 0;
                filmName = Console.ReadLine();

            }
            int sumAllTickets = countTicketStudent + countTicketStandard + countTicketKid;
            Console.WriteLine($"Total tickets: {sumAllTickets}");
            Console.WriteLine($"{countTicketStudent*1.0/ sumAllTickets*100:f2}% student tickets.");
            Console.WriteLine($"{countTicketStandard*1.0 / sumAllTickets*100:f2}% standard tickets.");
            Console.WriteLine($"{countTicketKid*1.0 / sumAllTickets*100:f2}% kids tickets.");

        }
    }
}
