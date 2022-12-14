using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ferrari
{
    public class Ferrari : Car
    {
        private string model;
        private string brakes;
        private string gasPedal;

        public Ferrari(string driversName)
        {
            this.DriversName = driversName;
            this.Model = model;
            this.GasPedal = gasPedal;
            this.Brakes = brakes;
        }

        public string DriversName { get; }

        public string Model
        {
            get { return this.model; }
            private set { this.model = "488-Spider"; }
        }

        public string Brakes
        {
            get { return this.brakes; }
            private set { this.brakes = "Brakes!"; }
        }

        public string GasPedal
        {
            get { return this.gasPedal; }
            private set { this.gasPedal = "Zadu6avam sA!"; }
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brakes}/{this.GasPedal}/{this.DriversName}";
        }
    }
}
