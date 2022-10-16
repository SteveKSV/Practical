using _02.Multiple_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_And_Abstraction
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = birthdate; 
        }

        public string Name { get; }
        public int Age { get; }
        public string ID { get; }
        public string Birthdate { get; }
    }
}
