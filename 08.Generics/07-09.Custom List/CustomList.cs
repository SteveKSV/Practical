using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_09.Custom_List
{
    public class CustomList<T> : ICustomList<T> where T : IComparable<T>
    {
        private List<T> List = new List<T>();

        public void Add(T element)
        {
            List.Add(element);
        }

        public T Remove(int index)
        {
            T element = List[index];
            List.RemoveAt(index);
            return element;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;
            foreach (var currentElem in List)
            {
                if (element.CompareTo(currentElem) < 0)
                {
                    count++;
                }
            }
            return count;
        }
        public bool Contains(T element)
        {
            foreach (var currentElem in List)
            {
                if (currentElem.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            T currentValue;
            currentValue = List[index1];
            List[index1] = List[index2];
            List[index2] = currentValue;
        }

        public T Max()
        {
            return List.Max();
        }

        public T Min()
        {
            return List.Min();
        }

        public void Print()
        {
            foreach (var elem in List)
            {
                Console.WriteLine(elem);
            }
        }

        public void Sort()
        {
            T element = List[0];
            List.Sort();
        }
        public IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}
