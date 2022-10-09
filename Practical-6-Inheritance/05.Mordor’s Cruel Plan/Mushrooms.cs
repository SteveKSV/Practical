using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan
{
    public class Mushrooms : AbstractFood
    {
        private const int MushroomsHappiness = -10;

        public Mushrooms() :
            base(MushroomsHappiness)
        { }
    }
}
