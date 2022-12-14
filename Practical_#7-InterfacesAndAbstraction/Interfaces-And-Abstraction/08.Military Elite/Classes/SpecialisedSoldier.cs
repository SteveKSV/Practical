using _08.Military_Elite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Military_Elite.Classes
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\nCorps: {this.Corps}\n";
        }
    }
}
