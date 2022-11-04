using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.VehicleCatalogue
{
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            AddVehicle(vehicles);
            PrintVehicle(vehicles);
            PrintAvgHorsepower(vehicles);            
        }

        public static void AddVehicle(List<Vehicle> vehicles)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = inputArgs[0];
                string model = inputArgs[1];
                string color = inputArgs[2];
                int horsePower = int.Parse(inputArgs[3]);

                if (type == "car")
                {
                    type = "Car";
                }
                else if (type == "truck")
                {
                    type = "Truck";
                }

                Vehicle newVehicle = new Vehicle(type, model, color, horsePower);

                vehicles.Add(newVehicle);

                input = Console.ReadLine();
            }
        }
        public static void PrintVehicle(List<Vehicle> vehicles)
        {
            string search = Console.ReadLine();

            while (search != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles.Where(m => m.Model == search))
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }

                search = Console.ReadLine();
            }
        }
        public static void PrintAvgHorsepower(List<Vehicle> vehicles)
        {
            int carsHPSum = 0;
            int trucksHPSum = 0;
            int countCars = 0;
            int countTrucks = 0;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == "Car")
                {
                    carsHPSum += vehicle.HorsePower;
                    countCars++;
                }
                else
                {
                    trucksHPSum += vehicle.HorsePower;
                    countTrucks++;
                }
            }  

            if (countCars > 0)
            {
                double avgHPCars = (double)carsHPSum / countCars;
                Console.WriteLine($"Cars have average horsepower of: {avgHPCars:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (countTrucks > 0)
            {
                double avgHPTrucks = (double)trucksHPSum / countTrucks;
                Console.WriteLine($"Trucks have average horsepower of: {avgHPTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            
        }
    }
}
