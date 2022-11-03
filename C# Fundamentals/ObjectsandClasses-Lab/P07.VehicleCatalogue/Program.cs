using System;
using System.Linq;
using System.Collections.Generic;

namespace P07.VehicleCatalogue
{
    class Program
    {
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        class Catalog
        {
            public Catalog()
            {
                this.Cars = new List<Car>();
                this.Trucks = new List<Truck>();
            }
            public List<Truck> Trucks { get; set; }
            public List<Car> Cars { get; set; }
        }
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string input = Console.ReadLine();            

            while (input != "end")
            {
                string[] vehicle = input
                    .Split("/", StringSplitOptions.RemoveEmptyEntries);
                string type = vehicle[0];

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = vehicle[1];
                    car.Model = vehicle[2];
                    car.HorsePower = int.Parse(vehicle[3]);

                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = vehicle[1];
                    truck.Model = vehicle[2];
                    truck.Weight = int.Parse(vehicle[3]);

                    catalog.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            catalog.Cars = catalog.Cars.OrderBy(x => x.Brand).ToList();
            catalog.Trucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();

            Console.WriteLine("Cars:");

            foreach (Car car in catalog.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");

            foreach (Truck truck in catalog.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
