using System;

namespace P02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int countDoctors = 7;

            for (int i = 1; i <= period; i++)
            {
                int countPatients = int.Parse(Console.ReadLine());                

                if (treatedPatients < untreatedPatients && i % 3 == 0)
                {
                    countDoctors++;                    
                }

                if (countPatients >= countDoctors)
                {
                    treatedPatients += countDoctors;                    
                    untreatedPatients += countPatients - countDoctors;
                }
                else
                {
                    treatedPatients += countPatients;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
