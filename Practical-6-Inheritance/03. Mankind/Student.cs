using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            private set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    value.ToCharArray();
                    for(int i = 0; i < value.Length; i++)
                    {
                        if (char.IsLetter(value[i]))
                        {
                            throw new ArgumentException("Invalid faculty number!");
                        }
                    }
                    
                }

                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("----------------Student---------------");
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");
            sb.AppendLine("--------------------------------------");
            return sb.ToString();
        }
    }
}
