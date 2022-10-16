using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.Food_Shortage.Interfaces;

namespace _07.Food_Shortage.Classes
{
    public class Citizen : IIdentible, IName, IBirthdate, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
        
        public void BuyFood()
        {
            this.Food += 10;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; }
    }
}
