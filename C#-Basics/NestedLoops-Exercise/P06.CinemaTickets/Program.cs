using System;
using System.Linq;

namespace P06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;


            string movieName = Console.ReadLine();

            while (movieName != "Finish")
            {

                int places = int.Parse(Console.ReadLine());

                int currTickets = 0;

                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {                    
                    currTickets++;

                    switch (ticketType)
                    {
                        case "student": studentTickets++; break;
                        case "standard": standardTickets++; break;
                        case "kid": kidTickets++; break;
                    }

                    if (currTickets == places)
                        break;

                    ticketType = Console.ReadLine();
                }

                Console.WriteLine($"{movieName} - {((double)currTickets / places) * 100:f2}% full.");

                if (ticketType == "Finish")
                    break;

                movieName = Console.ReadLine();

            }

            double totalTickets = studentTickets + standardTickets + kidTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTickets / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidTickets / totalTickets) * 100:f2}% kids tickets.");
        }
    }
}
