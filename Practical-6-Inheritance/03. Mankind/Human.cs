using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string FirstName
        {
            get { return firstName; }
            protected set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                if (value.Length <= 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");

                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            protected set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if (value.Length <= 2)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName)");
                }
                this.lastName = value;
            }
        }
    }
}
