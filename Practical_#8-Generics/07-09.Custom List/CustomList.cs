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
        private T[] List = Array.Empty<T>();

        public CustomList()
        {
            List = new T[0];
        }

        public void Add(T element)
        {
            var array = new T[List.Length + 1];

            for (int i = 0; i < List.Length; i++)
            {
                array[i] = List[i];
            }

            array[List.Length] = element;

            List = array;
        }

        public void Remove(int index)
        {
            var array = new T[List.Length - 1];

            for (int i = 0, j = 0; i < List.Length; i++)
            {
                if (i != index)
                {
                    array[j] = List[i];
                    j++;
                }
            }

            List = array;
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

        public IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }
        public void Sort()
        {
            T tempCollection = default(T);

            for (int i = 0; i < List.Length; i++)
            {
                for (int j = 0; j < List.Length - 1; j++)
                {
                    if (List[j + 1].CompareTo(List[j]) < 0)
                    {
                        tempCollection = List[j + 1];
                        List[j + 1] = List[j];
                        List[j] = tempCollection;
                    }
                }
            }
        }
    }
}
