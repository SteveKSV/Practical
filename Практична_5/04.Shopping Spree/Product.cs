using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shopping_Spree
{
   class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
            
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                this.name = value;
            }
        }

        public int Cost
        {
            get { return this.cost; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException($"Cost cannot be negative");
                this.cost = value;
            }
        }
    }
}
