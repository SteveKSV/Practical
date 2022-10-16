using _08.Military_Elite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Military_Elite.Classes
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}";
        }
    }
}
