using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        T[] elements;
        int count = 0;

        public Stack()
        {
            elements = new T[4];
        }

        public void Push(T element)
        {
            if (count == elements.Length)
                Resize(elements.Length + 1);

            elements[count++] = element;
        }

        public void Pop()
        {
            if (count == 0) throw new InvalidOperationException("Stack is empty");
            count--;
            T[] tempElements = new T[count];
            for (int i = 0; i < count; i++)
                tempElements[i] = elements[i];
            elements = tempElements;
        }

        private void Resize(int max)
        {
            T[] tempElements = new T[max];
            for (int i = 0; i < count; i++)
                tempElements[i] = elements[i];
            elements = tempElements;
        }

        public void Print()
        {
            foreach(T element in elements)
            {
                Console.WriteLine(element);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = count - 1; i >= 0; i--)
                yield return elements[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
