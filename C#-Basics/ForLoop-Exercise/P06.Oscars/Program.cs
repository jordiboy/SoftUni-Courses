using System;

namespace P06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string acterName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int countJurry = int.Parse(Console.ReadLine());

            double totalPoints;            

            for (int i = 1; i <= countJurry; i++)
            {
                string jurryName = Console.ReadLine();
                double jurryPoints = double.Parse(Console.ReadLine());

                int jurryLength = jurryName.Length;
                academyPoints += ((jurryLength * jurryPoints) / 2);                

                if (academyPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {acterName} got a nominee for leading role with {academyPoints:f1}!");
                    return;
                }
            } 
            
            Console.WriteLine($"Sorry, {acterName} you need {1250.5 - academyPoints:f1} more!");
        }
    }
}
