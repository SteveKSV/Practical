using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_7
{

    class Car
    {
        private string model;
        private decimal fuel;
        private decimal fuelConsumption;
        private decimal distance;

        public string Model { get; set; }
        public decimal Fuel { get; set; }
        public decimal FuelConsumption { get; set; }
        public decimal Distance { get; set; }

        public Car(string model, decimal fuel, decimal fuelCost)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelConsumption = fuelCost;
            this.Distance = 0;
        }

        public static bool CanDrive(Car car, decimal distance)
        {
            var km = car.Fuel / car.FuelConsumption;
            if (km >= distance)
            {
                var liters = distance * car.FuelConsumption;
                car.Fuel -= liters;
                car.Distance += distance;
                return true;
            }

            return false;
        }
        class Program
        {
            static void Main()
            {
                var cars = new List<Car>();

                var n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    var carInformation = Console.ReadLine().Split();
                    var model = carInformation[0];
                    var fuel = decimal.Parse(carInformation[1]);
                    var fuelConsumption = decimal.Parse(carInformation[2]);

                    cars.Add(new Car(model, fuel, fuelConsumption));
                }

                var drive = Console.ReadLine();
                while (!drive.Equals("End"))
                {
                    var elementsOfString = drive.Split();
                    var model = elementsOfString[1];
                    var distance = decimal.Parse(elementsOfString[2]);

                    var currentCar = cars.FirstOrDefault(c => c.Model == model);

                    if (!Car.CanDrive(currentCar, distance))
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }

                    drive = Console.ReadLine();
                }

                foreach (var car in cars)
                {
                    Console.WriteLine($"{car.Model} {car.Fuel:f2} {(int)car.Distance}");
                }
            }
        }
    }
}