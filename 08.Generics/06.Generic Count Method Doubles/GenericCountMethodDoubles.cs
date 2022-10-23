using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Generic_Count_Method_Doubles
{
    public class GenericCountMethodDoubles<T> where T : IComparable<T>
    {
        public List<T> List { get; set; }

        public int CountMethod(List<T> elements, T someElement)
        {
            int counter = 0;
            foreach (var element in elements)
            {
                if (someElement.CompareTo(element) < 0)
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
