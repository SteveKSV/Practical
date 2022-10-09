using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan
{
    public class EverythingElse : AbstractFood
    {
        private const int EverythingElseHappiness = -1;

        public EverythingElse()
            :base(EverythingElseHappiness)
        {
        }
    }
}
