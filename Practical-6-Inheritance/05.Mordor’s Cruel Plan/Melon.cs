using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan
{
    public class Melon : AbstractFood
    {
        private const int MelonHappiness = 1;

        public Melon()
            : base(MelonHappiness)
        { }
    }
}
