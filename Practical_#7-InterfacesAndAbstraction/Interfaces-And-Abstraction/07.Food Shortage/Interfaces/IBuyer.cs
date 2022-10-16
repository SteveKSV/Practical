using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Food_Shortage.Interfaces
{
    public interface IBuyer
    {
        int Food { get; set; }

        void BuyFood();
    }
}
