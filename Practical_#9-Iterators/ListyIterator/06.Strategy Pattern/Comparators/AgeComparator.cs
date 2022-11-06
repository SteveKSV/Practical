using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strategy_Pattern.Comparators
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person? p1, Person? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Invalid people!");

            if(p1.Age > p2.Age)
            {
                return 1;
            } else if (p1.Age < p2.Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
