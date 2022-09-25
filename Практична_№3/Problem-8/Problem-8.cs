using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_8
{
    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }

    public class Cargo
    {
        public string Type { get; set; }
        public int Weight { get; set; }

        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
    }

    public class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
    }
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = new Tire[4];
        }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInformation = Console.ReadLine().Split();
                var model = carInformation[0];
                var engineSpeed = int.Parse(carInformation[1]);
                var enginePower = int.Parse(carInformation[2]);
                var cargoWeight = int.Parse(carInformation[3]);
                var cargoType = carInformation[4];

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoType, cargoWeight);
                var tires = new Tire[4];
                var indexForTires = 0;

                for (int j = 0; j < 8; j+=2)
                {
                    var tirePressure = double.Parse(carInformation[5 + j]);
                    var tireAge = int.Parse(carInformation[6 + j]);
                    var currentTire = new Tire(tirePressure, tireAge);
                    tires[indexForTires] = currentTire;
                    indexForTires++;
                }

                var car = new Car(model, engine, cargo);
                car.Tires = tires;
                cars.Add(car);
            }

            var result = new List<Car>();

            var typeOfCargo = Console.ReadLine();

            if (typeOfCargo == "fragile")
            {
                result = cars.Where(c => c.Cargo.Type.Equals("fragile") && c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else if (typeOfCargo == "flamable")
            {
                result = cars.Where(c => c.Cargo.Type.Equals("flamable") && c.Engine.Power > 250).ToList();
            }

            foreach (var car in result)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
