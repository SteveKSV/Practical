using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Problem_10
{
    public class Engine
    {
        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }
    }
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            sb.AppendLine($"  Weight: {this.Weight}");
            sb.AppendLine($"  Color: {this.Color}");

            return sb.ToString().Trim();
        }
    }
        class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                var engineInfo = Console.ReadLine().Split();
                var engine = new Engine(engineInfo[0], engineInfo[1]);

                if (engineInfo.Length >= 3)
                {
                    if (engineInfo[2].All(s => char.IsDigit(s)))
                    {
                        engine.Displacement = engineInfo[2];
                    }
                    else
                    {
                        engine.Efficiency = engineInfo[2];
                    }
                }

                if (engineInfo.Length == 4)
                {
                    engine.Efficiency = engineInfo[3];
                }

                engines.Add(engine);
            }

            n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var car = new Car(carInfo[0], engines.FirstOrDefault(e => e.Model.Equals(carInfo[1])));

                if (carInfo.Length >= 3)
                {
                    if (carInfo[2].All(s => char.IsDigit(s)))
                    {
                        car.Weight = carInfo[2];
                    }
                    else
                    {
                        car.Color = carInfo[2];
                    }
                }

                if (carInfo.Length == 4)
                {
                    car.Color = carInfo[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
