using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_Swap_Method_Strings
{
    public class GenericSwapMethodStrings<T>
    {
        public List<T> StringList { get; set; }

        public List<T> SwapFromList(List<T> stringList, int firstIndex, int secondIndex)
        {
            T currentValue;
            currentValue = stringList[firstIndex];
            stringList[firstIndex] = stringList[secondIndex];
            stringList[secondIndex] = currentValue;
            return stringList;
        }

        public void PrintElem(List<T> stringList)
        {
            foreach (T currentElem in stringList)
            {
                Console.WriteLine($"{currentElem.GetType().FullName}: {currentElem}");
            }
        }
    }
}
