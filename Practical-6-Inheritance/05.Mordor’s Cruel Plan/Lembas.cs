using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan
{
    public class Lembas : AbstractFood
    {
        private const int LembasHappiness = 3;
        public Lembas ()
            :base(LembasHappiness)
        {
        }
    }
}
