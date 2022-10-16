using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ferrari
{
    public interface Car
    {
        string Model { get; }
        string Brakes { get; }
        string GasPedal { get; }
        string DriversName { get; }
    }
}
