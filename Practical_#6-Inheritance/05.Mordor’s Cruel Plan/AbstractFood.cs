using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan
{
    public abstract class AbstractFood
    {
        public AbstractFood(int happiness)
        {
            this.Happiness = happiness;
        }

        public int Happiness { get; set; }
    }
}
