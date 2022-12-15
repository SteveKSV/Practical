using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Force.Employees
{
    public class PartTimeEmployee : Employee
    {
        private const int WeeklyWorkingHours = 20;

        public PartTimeEmployee(string name)
            : base(name, WeeklyWorkingHours)
        {
        }
    }
}
