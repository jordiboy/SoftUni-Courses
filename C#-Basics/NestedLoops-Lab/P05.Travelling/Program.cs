using System;

namespace P05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";

            while ((destination = Console.ReadLine()) != "End")
            {
                double budgetNeeded = double.Parse(Console.ReadLine());
                double total = 0;                

                while (budgetNeeded >= total)
                {
                    string input = Console.ReadLine();

                    if (input != "End")
                    {
                        double saving = double.Parse(input);
                        total += saving;
                    }
                    else
                    {
                        break;
                    }
                    if (total >= budgetNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }                
            }
        }
    }
}
