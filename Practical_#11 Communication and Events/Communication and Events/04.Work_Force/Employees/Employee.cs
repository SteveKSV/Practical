using System;
using System.Collections.Generic;
using System.Text;
using Work_Force.Interfaces;
namespace Work_Force.Employees
{
    public abstract class Employee : IEmployee
    {
        public Employee(string name, int weeklyWorkingHours)
        {
            this.Name = name;
            this.WorkHoursPerWeek = weeklyWorkingHours;
        }
        public string Name { get; set; }

        public int WorkHoursPerWeek { get; }
    }
}
