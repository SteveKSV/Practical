using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan.FoodList
{
    public class HoneyCake : AbstractFood
    {
        private const int HoneyCakeHappiness = 5;

        public HoneyCake()
            : base(HoneyCakeHappiness) { }
    }
}
