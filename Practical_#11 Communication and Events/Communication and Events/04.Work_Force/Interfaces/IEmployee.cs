using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Force.Interfaces
{
    public interface IEmployee
    {
        string Name { get; }

        int WorkHoursPerWeek { get; }
    }
}
