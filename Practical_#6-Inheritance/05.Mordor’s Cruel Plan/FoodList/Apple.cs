using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan.FoodList
{
    public class Apple : AbstractFood
    {
        private const int AppleHappiness = 1;

        public Apple()
            : base(AppleHappiness)
        { }
    }
}
