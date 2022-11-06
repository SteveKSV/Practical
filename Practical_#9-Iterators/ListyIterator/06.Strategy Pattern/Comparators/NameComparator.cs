using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strategy_Pattern.Comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person? p1, Person? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Invalid people!");
            if (p1.Name.Length > p2.Name.Length)
            {
                return 1;
            }
            else if (p1.Name.Length < p2.Name.Length)
            {
                return -1;
            }
            else if (p1.Name.Length == p2.Name.Length)
            {

                int counter = 0;

                for (int i = 0; i < p1.Name.Length; i++)
                {
                    char c1 = char.ToLower(p1.Name[i]);
                    char c2 = char.ToLower(p2.Name[i]);

                    if (c1 > c2)
                    {
                        return 1;
                    }
                    else if (c1 < c2)
                    {
                        return -1;
                    }
                }
            }

            return 0;
        }
    }
}
