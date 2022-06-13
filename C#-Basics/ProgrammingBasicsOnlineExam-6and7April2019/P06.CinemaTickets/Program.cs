using System;

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
                int freePlaces = int.Parse(Console.ReadLine());
                string typeTicket = Console.ReadLine();
                int currTicket = 0;

                while (typeTicket != "End")
                {
                    currTicket++;

                    switch (typeTicket)
                    {
                        case "student": studentTickets++; break;
                        case "standard": standardTickets++; break;
                        case "kid": kidTickets++; break;
                    }

                    if (currTicket == freePlaces)
                    {
                        break;
                    }

                    typeTicket = Console.ReadLine();
                }

                Console.WriteLine($"{movieName} - {((double)currTicket / freePlaces) * 100:f2}% full.");

                if (typeTicket == "Finish")
                {
                    break;
                }

                movieName = Console.ReadLine();
            }

            double totalTickets = standardTickets + studentTickets + kidTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTickets / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidTickets / totalTickets) * 100:f2}% kids tickets.");
        }
    }
}
