using System;

namespace P01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commandArgs = command.Split(":");

                string action = commandArgs[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    string text = commandArgs[2];

                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, text);
                    }
                    Console.WriteLine(stops);
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endtIndex = int.Parse(commandArgs[2]);                    

                    if (startIndex >= 0 && startIndex < stops.Length 
                        && endtIndex >= 0 && endtIndex < stops.Length)
                    {
                        int count = endtIndex - startIndex;
                        stops = stops.Remove(startIndex, count + 1);
                    }
                    Console.WriteLine(stops);
                }
                else if (action == "Switch")
                {
                    string oldString = commandArgs[1];
                    string newString = commandArgs[2];

                    stops = stops.Replace(oldString, newString);

                    Console.WriteLine(stops);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
