using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Calories
{
    public class Topping
    {
        private readonly string[] ToppingTypes = { "meat", "veggies", "cheese", "sauce" };
        private const int MinWeight = 1;
        private const int MaxWeight = 50;
        private const decimal MeatValue = 1.2m;
        private const decimal VeggiesValue = 0.8m;
        private const decimal CheeseValue = 1.1m;
        private const decimal SauceValue = 0.9m;
        private List<Topping> toppings;
        public List<Topping> Toppings { get { return this.toppings; } set { this.toppings = value; } }

        private string type;
        private double weight;

        public Topping(string type, double weight, List<Topping> toppings)
        {
            this.Type = type;
            this.Weight = weight;
            this.toppings = toppings;
        }

        public Topping()
        {

        }
        public string Type
        {
            get { return this.type; }
            private set
            {
                if (!ToppingTypes.Contains(value.ToLower()) || value == null || value == "" || value == " ")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [{MinWeight}..{MaxWeight}].");
                }

                this.weight = value;
            }
        }

        public decimal CalcCalories()
        {
            var typeValue = 0.0m;
            switch (this.type.ToLower())
            {
                case "meat":
                    typeValue = MeatValue;
                    break;
                case "veggies":
                    typeValue = VeggiesValue;
                    break;
                case "cheese":
                    typeValue = CheeseValue;
                    break;
                case "sauce":
                    typeValue = SauceValue;
                    break;
            }

            return 2 * typeValue * (decimal)this.Weight;
        }
    }
}
