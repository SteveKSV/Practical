using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Military_Elite.Interfaces
{
    public interface ISoldier
    {
        string Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }
    }
}
