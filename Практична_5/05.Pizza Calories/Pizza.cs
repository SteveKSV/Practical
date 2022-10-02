using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private int toppingCount;
        
        public Pizza(string name, int toppingCount)
        {
            this.Name = name;
            this.ToppingCount = toppingCount;
        }

        public Pizza()
        {

        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int ToppingCount
        {
            get { return this.toppingCount; }
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.toppingCount = value;
            }
        }

        public double CalcCalories(List<Topping> toopings, Dough dough)
        {
            double sum = 0;
            for (int i = 0; i < toopings.Count; i++)
            {
                sum += (double)toopings[i].CalcCalories();
            }
            double doughCalories = (double)dough.CalcCalories();
            return doughCalories + sum;
        }
    }
}
