using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan.FoodList
{
    public class Cram : AbstractFood
    {
        private const int CramHappiness = 2;

        public Cram() :
            base(CramHappiness)
        {
        }
    }
}
