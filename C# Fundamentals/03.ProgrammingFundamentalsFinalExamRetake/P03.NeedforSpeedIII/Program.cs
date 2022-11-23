using System;
using System.Collections.Generic;

namespace P03.NeedforSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                string carName = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                if (!cars.ContainsKey(carName))
                {
                    cars.Add(carName, new int[2]);
                }

                cars[carName][0] = mileage;
                cars[carName][1] = fuel;
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string car = commandArgs[1];

                if (action == "Drive")
                {
                    int distance = int.Parse(commandArgs[2]);
                    int neededFuel = int.Parse(commandArgs[3]);

                    if (cars[car][1] >= neededFuel)
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= neededFuel;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                    if (cars[car][0] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");

                        cars.Remove(car);
                    }
                }
                else if (action == "Refuel")
                {
                    int fuel = int.Parse(commandArgs[2]);

                    if (cars[car][1] + fuel >= 75)
                    {                        
                        Console.WriteLine($"{car} refueled with {75 - cars[car][1]} liters");

                        cars[car][1] = 75;
                    }
                    else
                    {
                        cars[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }                    
                }
                else if (action == "Revert")
                {
                    int kilometers = int.Parse(commandArgs[2]);

                    cars[car][0] -= kilometers;

                    if (cars[car][0] < 10000)
                    {
                        cars[car][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
