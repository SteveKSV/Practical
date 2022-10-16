using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Military_Elite.Interfaces
{
    public interface IRepair
    {
        string PartName { get; set; }
        int HoursWorked { get; set; }
    }
}
