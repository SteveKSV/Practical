using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class Lake<T> : IEnumerable<int>
    {
        int[] elements; 

        public Lake(int[] elements)
        {
            this.elements = elements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < elements.Length; i += 2)
            {
                yield return elements[i];
            }

            var reverseLength = elements.Length - 1;

            if (elements.Length % 2 != 0)
            {
                reverseLength = elements.Length - 2;
            }

            for (int i = reverseLength; i > 0; i -= 2)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
