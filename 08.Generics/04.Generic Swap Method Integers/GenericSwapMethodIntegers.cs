using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Generic_Swap_Method_Integers
{
    public class GenericSwapMethodIntegers<T>
    {
        public List<T> IntList { get; set; }

        public List<T> SwapFromList(List<T> intList, int firstIndex, int secondIndex)
        {
            T currentValue;
            currentValue = intList[firstIndex];
            intList[firstIndex] = intList[secondIndex];
            intList[secondIndex] = currentValue;

            return intList;
        }

        public void PrintElem(List<T> intList)
        {
            foreach (T currentElem in intList)
            {
                Console.WriteLine($"{currentElem.GetType().FullName}: {currentElem}");
            }
        }
    }
}
