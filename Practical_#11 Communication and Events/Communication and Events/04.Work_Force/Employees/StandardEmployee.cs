using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Force.Employees
{
    public class StandardEmployee : Employee
    {
        private const int WeeklyWorkingHours = 40;

        public StandardEmployee(string name)
            : base(name, WeeklyWorkingHours)
        {
        }
    }
}
